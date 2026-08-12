# Vcenter.Automation.OpenApi.Model.VcenterVmToolsUpdateSpec
The (@name UpdateSpec} schema describes the VMware Tools properties of a virtual machine that can be updated.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UpgradePolicy** | **string** | Tools upgrade policy setting for the virtual machine. *Vcenter.Vm.Tools.UpgradePolicy*  Possible values:   - &#x60;MANUAL&#x60;: No auto-upgrades for Tools will be performed for this virtual machine. Users must manually invoke the *POST /vcenter/vm/{vm}/tools?action&#x3D;upgrade* operation to update Tools.   - &#x60;UPGRADE_AT_POWER_CYCLE&#x60;: When the virtual machine is power-cycled, the system checks for a newer version of Tools when the virtual machine is powered on. If it is available, a Tools upgrade is automatically performed on the virtual machine and it is rebooted if necessary.   For more information see: *Vcenter.Vm.Tools.UpgradePolicy*.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; the upgrade policy will not be modified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

