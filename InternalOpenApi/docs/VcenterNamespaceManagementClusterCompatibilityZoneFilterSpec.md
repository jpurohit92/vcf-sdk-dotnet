# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementClusterCompatibilityZoneFilterSpec
The Vcenter.NamespaceManagement.ClusterCompatibility.ZoneFilterSpec schema contains properties used to filter the results when listing vSphere Zones (see *GET /vcenter/namespace-management/cluster-compatibility/v2*) and their compatibility information.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zones** | **List&lt;string&gt;** | A list of vSphere Zone identifiers which will be used to filter vSphere Zones that correspond to this specific set of identifiers.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60; or empty, results will not be filtered for specific vSphere Zone identifiers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

