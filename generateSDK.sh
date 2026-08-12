#!/usr/bin/env bash
set -e

echo "--> Cleaning output directories..."
rm -rf ./InternalViJson ./InternalOpenApi
echo "--> Generating VI/JSON SDK..."
_JAVA_OPTIONS="-DmaxYamlCodePoints=99999999" openapi-generator generate \
  -i resources/vi-json.yaml \
  -g csharp \
  -t templates/csharp \
  -o ./InternalViJson \
  --package-name Vcenter.ViJson.OpenApi \
  --additional-properties targetFramework=net8.0,library=restsharp,useOneOfDiscriminatorLookup=true,nullableReferenceTypes=true \
  --global-property apis="SessionManager:Folder:VirtualMachine",models,supportingFiles,tests=false \
  --skip-validate-spec

echo "--> Generating REST SDK..."
# Generate REST SDK with ONLY specified APIs
_JAVA_OPTIONS="-DmaxYamlCodePoints=99999999" openapi-generator generate \
  -i resources/vcenter.yml \
  -g csharp \
  -o ./InternalOpenApi \
  --package-name Vcenter.Automation.OpenApi \
  --additional-properties targetFramework=net8.0,library=restsharp,nullableReferenceTypes=true \
  --global-property apis="CisSession:VcenterDatastore:VcenterFolder:VcenterResourcePool:VcenterVM",models,supportingFiles,tests=false \
  --skip-validate-spec

echo "SDK Generation Completed!"