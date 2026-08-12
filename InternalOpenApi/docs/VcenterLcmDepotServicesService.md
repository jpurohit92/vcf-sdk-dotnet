# Vcenter.Automation.OpenApi.Model.VcenterLcmDepotServicesService
The Vcenter.Lcm.Depot.Services.Service schema defines the connection configuration for specific service  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | External service name  This property was added in __vSphere API 9.1.0.0__. | 
**Type** | **string** | Type of external service Supported type is VCF_DEPOT  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SERVICEID&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SERVICEID&#x60;. | 
**Key** | **string** | External service key, identifier for the service unique across the fleet  This property was added in __vSphere API 9.1.0.0__. | 
**VarVersion** | **string** | External service version  This property was added in __vSphere API 9.1.0.0__.  as this is not a required configuration field for external connections | [optional] 
**Nodes** | [**List&lt;VcenterLcmDepotServicesNode&gt;**](VcenterLcmDepotServicesNode.md) | List of nodes/instances belonging to the same external service  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

