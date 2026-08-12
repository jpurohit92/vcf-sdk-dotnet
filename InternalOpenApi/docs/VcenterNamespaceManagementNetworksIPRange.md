# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksIPRange
  The Vcenter.NamespaceManagement.Networks.IPRange schema is used to express a range of IP addresses. The IP address supported by this structure will depend on the IP version that is being used by Supervisor.   Currently, the Supervisor only supports IPv4.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | *Vcenter.NamespaceManagement.Networks.IPRange.address* is the starting IP address of the Vcenter.NamespaceManagement.Networks.IPRange.  This property was added in __vSphere API 8.0.0.1__. | 
**Count** | **long** |   *Vcenter.NamespaceManagement.Networks.IPRange.count* is number of IP addresses in the range.   For example:   A /24 subnet will have a count of 256.   A /24 subnet with a gateway address and a broadcast address will have a count of 254.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

