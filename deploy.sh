#!/bin/bash
set -euo pipefail

export ROOT=.;source $ROOT/scripts/base.sh

pushd pac/net/tye
./deploy.sh ${BASENAME}
popd