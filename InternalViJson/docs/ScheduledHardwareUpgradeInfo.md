# Vcenter.ViJson.OpenApi.Model.ScheduledHardwareUpgradeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UpgradePolicy** | **string** | Scheduled hardware upgrade policy setting for the virtual machine.  See also *ScheduledHardwareUpgradeInfoHardwareUpgradePolicy_enum*.  | [optional] 
**VersionKey** | **string** | Key for target hardware version to be used on next scheduled upgrade in the format of *VirtualMachineConfigOptionDescriptor.key*.  | [optional] 
**ScheduledHardwareUpgradeStatus** | **string** | Status for last attempt to run scheduled hardware upgrade.  See also *ScheduledHardwareUpgradeInfoHardwareUpgradeStatus_enum*.  | [optional] 
**Fault** | [**MethodFault**](MethodFault.md) | Contains information about the failure of last attempt to run scheduled hardware upgrade.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

