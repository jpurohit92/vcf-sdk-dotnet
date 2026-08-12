# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksNsxDistributedSwitchesCompatibilitySummary
This schema is deprecated as of __vSphere API 9.1.0.0__.  The Vcenter.NamespaceManagement.Networks.Nsx.DistributedSwitches.Compatibility.Summary schema contains basic and compatibility information of a Distributed Switch.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DistributedSwitch** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Identifier of the switch. The value of this field refers to the UUID of a vim.DistributedVirtualSwitch.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;vSphereDistributedSwitch&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;vSphereDistributedSwitch&#x60;. | 
**Name** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Human-readable identifier of the switch.  This property was added in __vSphere API 8.0.0.1__. | 
**Compatible** | **bool** | This property is deprecated as of __vSphere API 9.1.0.0__.  Compatibility of this Distributed Switch with the vSphere Namespaces.  This property was added in __vSphere API 8.0.0.1__. | 
**IncompatibilityReasons** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | This property is deprecated as of __vSphere API 9.1.0.0__.  List of reasons for incompatibility. If empty, this Distributed Switch is compatible.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

