# Vcenter.ViJson.OpenApi.Model.VsanSpaceQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | Specify the entity type which is queried for the vSAN space usage computing by aggregating all of vSAN objects belonging to the entity.  Please refer to *VsanSpaceReportingEntityType_enum* for all of entity types.  See also *VsanSpaceReportingEntityType_enum*.  | 
**EntityIds** | **List&lt;string&gt;** | Specify the entities UUID for query.  For the virtual machine, it&#39;s the managed object id like \&quot;vm-1\&quot;. The maximum number of supported entities is 100 in one query.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

