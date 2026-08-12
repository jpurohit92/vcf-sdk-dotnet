# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNSXTier0GatewaySummary
The Vcenter.NamespaceManagement.NSXTier0Gateway.Summary schema contains information about an NSX Tier0 Gateway.  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tier0Gateway** | **string** | Identifier of the NSX Tier0 or Tier0-VRF Gateway.  This property was added in __vSphere API 7.0.2.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;NSXTier0Gateway&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;NSXTier0Gateway&#x60;. | 
**DisplayName** | **string** | Display name of the NSX Gateway.  This property was added in __vSphere API 7.0.2.0__. | 
**Description** | **string** | Description of the NSX Gateway.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the gateway has no description set. | [optional] 
**Path** | **string** | NSX Policy path of the NSX Gateway.  This property was added in __vSphere API 7.0.2.0__. | 
**ParentTier0Gateway** | **string** | Parent Tier0 of the NSX Tier0-VRF Gateway.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the gateway is not Tier0-VRF.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;NSXTier0Gateway&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;NSXTier0Gateway&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

