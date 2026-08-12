# Vcenter.Automation.OpenApi.Model.VcenterVmToolsUpgradePolicy
The Vcenter.Vm.Tools.UpgradePolicy enumerated type defines when Tools are auto-upgraded for a virtual machine.  Possible values:   - `MANUAL`: No auto-upgrades for Tools will be performed for this virtual machine. Users must manually invoke the *POST /vcenter/vm/{vm}/tools?action=upgrade* operation to update Tools.   - `UPGRADE_AT_POWER_CYCLE`: When the virtual machine is power-cycled, the system checks for a newer version of Tools when the virtual machine is powered on. If it is available, a Tools upgrade is automatically performed on the virtual machine and it is rebooted if necessary.   This enumeration was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

