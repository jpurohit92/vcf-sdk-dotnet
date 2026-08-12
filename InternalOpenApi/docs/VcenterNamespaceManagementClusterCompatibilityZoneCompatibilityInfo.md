# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClusterCompatibilityZoneCompatibilityInfo
The Vcenter.NamespaceManagement.ClusterCompatibility.ZoneCompatibilityInfo schema contains the information about the compatibility between a list of vSphere Zones.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Compatible** | **bool** | Flag to indicate whether the vSphere Zones are compatible with each other. If false, the list of incompatibility issues will be given in the incompatibility_reasons field.  This property was added in __vSphere API 8.0.0.1__. | 
**ZoneSummaries** | [**List&lt;VcenterNamespaceManagementClusterCompatibilityZoneSummary&gt;**](VcenterNamespaceManagementClusterCompatibilityZoneSummary.md) | Information about the compatibility of a list of vSphere Zones and the vSphere clusters associated with them.  This property was added in __vSphere API 8.0.0.1__. | 
**IncompatibilityReasons** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | Reasons for incompatibility between the vSphere Zones.  This property was added in __vSphere API 8.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

