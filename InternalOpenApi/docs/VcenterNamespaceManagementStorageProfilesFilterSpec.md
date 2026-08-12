# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementStorageProfilesFilterSpec
The Vcenter.NamespaceManagement.Storage.Profiles.FilterSpec schema contains zones used to find compatible storage profiles. A storage profile is compatible if it results in at least one datastore in each of the specified zones. (see *POST /vcenter/namespace-management/storage/profiles?action=check_compatibility*).  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zones** | **List&lt;string&gt;** | Zone compatibility criteria. The common storage profiles across the given zones will be returned. A storage profile is considered compatible if it results in at least one datastore in each of the given zones.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

