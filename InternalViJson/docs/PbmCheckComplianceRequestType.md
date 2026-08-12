# Vcenter.ViJson.OpenApi.Model.PbmCheckComplianceRequestType
The parameters of *PbmComplianceManager.PbmCheckCompliance*.  This structure may be used only with operations rendered under `/pbm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entities** | [**List&lt;PbmServerObjectRef&gt;**](PbmServerObjectRef.md) | One or more references to storage entities. You can specify virtual machines and virtual disks A maximum of 1000 virtual machines and/or virtual disks can be specified in a call. The results of calling the checkCompliance API with more than a 1000 entities is undefined. - If the list of entities also contains datastores, the Server   will ignore the datastores. - If the list contains valid and invalid entities, the Server ignores   the invalid entities and returns results for the valid entities.   Invalid entities are entities that are not in the vCenter inventory. - If the list contains only datastores, the method throws   an &lt;code&gt;InvalidArgument&lt;/code&gt; fault. - If the list contains virtual machines and disks and the entities   are invalid or have been deleted by the time of the request, the method   throws an &lt;code&gt;InvalidArgument&lt;/code&gt; fault.    If an entity does not have an associated storage profile, the entity is removed from the list.  | 
**Profile** | [**PbmProfileId**](PbmProfileId.md) | Not used. If specified, the Server ignores the value. The Server uses the profiles associated with the specified entities.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

