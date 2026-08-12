# Vcenter.Automation.OpenApi.Model.VcenterHostHardwareDirectPathDevicesConfigureResult
The Vcenter.Host.Hardware.DirectPathDevices.ConfigureResult schema contains information about the results of reconfiguring a DirectPath device.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigureImpacts** | **List&lt;string&gt;** | The impact of running the reconfigure operation.  Possible values:   - &#x60;NONE&#x60;: No impact to the host or any virtual machines.   - &#x60;HOST_MAINTENANCE_MODE_REQUIRED&#x60;: Host needs to go through maintenance mode for the desired configuration changes to take effect.   - &#x60;HOST_REBOOT_REQUIRED&#x60;: Host needs to be rebooted for the desired configuration changes to take effect.   For more information see: *Vcenter.Host.Hardware.DirectPathDevices.ConfigureImpact*.  This property was added in __vSphere API 9.1.0.0__.  is missing or &#x60;null&#x60;, if the operation fails. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

