# Vcenter.Automation.OpenApi.Model.VcenterVmGuestNetworkingInterfacesInfo
The Vcenter.Vm.Guest.Networking.Interfaces.Info schema describes a virtual network adapter configured in the guest operating system.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DnsValues** | [**VcenterVmGuestDnsAssignedValues**](VcenterVmGuestDnsAssignedValues.md) | Client DNS values. Data assigned by DNS.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; no DNS assigned value exists. | [optional] 
**MacAddress** | **string** | MAC address of the adapter.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; then not supported by the Guest OS. | [optional] 
**Dns** | [**VcenterVmGuestDnsConfigInfo**](VcenterVmGuestDnsConfigInfo.md) | DNS configuration of the adapter. See *Vcenter.Vm.Guest.Networking.Info.dns* for system wide settings.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; then not assigned by the Guest OS. | [optional] 
**Ip** | [**VcenterVmGuestNetworkingInterfacesIpConfigInfo**](VcenterVmGuestNetworkingInterfacesIpConfigInfo.md) | IP configuration settings of the adapter  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; then not supported by the Guest OS. | [optional] 
**WinsServers** | **List&lt;string&gt;** | The IP addresses of any WINS name servers for the adapter.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; then not supported by the Guest OS. | [optional] 
**Nic** | **string** | Link to the corresponding virtual device.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; then the interface is not backed by a virtual device.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Ethernet&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.vm.hardware.Ethernet&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

