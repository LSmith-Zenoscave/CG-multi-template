#!/bin/bash

set -e
set -x

cp dist/Solution.cs versions/Solution_$(date +%Y-%m-%d_%H-%M-%S).cs