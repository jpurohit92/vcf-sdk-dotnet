# Vcenter.Automation.OpenApi.Model.VcenterStoragePoliciesFilterSpec
The Vcenter.Storage.Policies.FilterSpec schema contains properties used to filter the results when listing the storage policies (see *GET /vcenter/storage/policies*)  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policies** | **List&lt;string&gt;** | Identifiers of storage policies that can match the filter.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; or empty, storage policies with any identifiers match the filter.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.StoragePolicy&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.StoragePolicy&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

