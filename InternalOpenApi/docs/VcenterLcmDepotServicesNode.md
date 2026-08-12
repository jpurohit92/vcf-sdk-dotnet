# Vcenter.Automation.OpenApi.Model.VcenterLcmDepotServicesNode
The Vcenter.Lcm.Depot.Services.Node schema defines the external service node configurations  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Common name of the service node  This property was added in __vSphere API 9.1.0.0__. | 
**Addresses** | [**List&lt;VcenterLcmDepotServicesAddress&gt;**](VcenterLcmDepotServicesAddress.md) | List of addresses to connect to the service node.  This property was added in __vSphere API 9.1.0.0__. | 
**Port** | **string** | Service node port on which the service is hosted  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the connection will be done with the default port | [optional] 
**BaseUrl** | **string** | URL prefix pointing to the root of the service  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, it defaults to \&quot;/\&quot; indicating that the service root is hosted directly at the specified address. | [optional] 
**Certificates** | **List&lt;string&gt;** | Certificates to be used to securely connect with the service node.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

