#!/bin/bash

set -e
set -x

if ! kill -0 $(cat cgsharp.pid) >/dev/null 2>&1 ; then
    CSharpMerger >build.log 2>build.error.log &
    echo $! > cgsharp.pid
fi

dotnet build
dotnet publish -c release -r linux-x64 -p:PublishSingleFile=true --self-contained true