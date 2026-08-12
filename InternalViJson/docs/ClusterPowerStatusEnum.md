# Vcenter.ViJson.OpenApi.Model.ClusterPowerStatusEnum
Defines the detailed cluster wide power action.  Possible values: - `clusterPoweredOn`: indicate the cluster is in running state. - `haDisabled`: vSphere HA is disabled. - `supportedVMsPoweredOff`: the supported system VMs are powered off. - `vcVMPoweredOff`: power off the VC VM if the VC VM is on vSAN. - `vsanMemberShipUpdateDisabled`: vSAN membership updates is disabled. - `vsanDOMPauseAllCCPsSet`: DOMPauseAllCCPs is set. - `hostsInMM`: all hosts are in maintenance mode. - `hostsPoweredOff`: power-off operations have been triggered on all hosts. - `clusterPoweredOff`: indicate the cluster is in shutdown state. - `hostsOutOfMM`: all hosts are out of maintenance mode. - `vsanMemberShipUpdateEnabled`: vSAN membership updates is enabled. - `vsanDOMPauseAllCCPsUnset`: DOMPauseAllCCPs is unset. - `vcVMPoweredOn`: power on the VC VMs if it the VC VM is on vSAN. - `supportedVMsPoweredOn`: the supported system VMs are powered on. - `haEnabled`: vSphere HA is enabled. - `infraVMsRecorded` - `hostsInfraVMsPoweredoff` - `hostsInfraVMsPoweredon` - `ClusterPowerStatus_Unknown`: represent the value when the lower version client cannot recognize the enum value. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

