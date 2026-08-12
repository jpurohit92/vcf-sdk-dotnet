# Vcenter.Automation.OpenApi.Model.VcenterVmGuestNetworkingInfo
The Vcenter.Vm.Guest.Networking.Info schema contains information about networking as configured in the guest operating system.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DnsValues** | [**VcenterVmGuestDnsAssignedValues**](VcenterVmGuestDnsAssignedValues.md) | Client DNS values. Data assigned by DNS.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; no DNS assigned value exists. | [optional] 
**Dns** | [**VcenterVmGuestDnsConfigInfo**](VcenterVmGuestDnsConfigInfo.md) | Client DNS configuration. How DNS queries are resolved.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; no DNS assigned value exists. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

