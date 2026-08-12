# Vcenter.ViJson.OpenApi.Model.PbmFetchComplianceResultRequestType
The parameters of *PbmComplianceManager.PbmFetchComplianceResult*.  This structure may be used only with operations rendered under `/pbm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entities** | [**List&lt;PbmServerObjectRef&gt;**](PbmServerObjectRef.md) | One or more references to storage entities. A maximum of 1000 virtual machines and/or virtual disks can be specified in a call. The results of calling the fetchComplianceResult API with more than a 1000 entities is undefined. - If the list of entities also contains datastores, the Server   will ignore the datastores. - If the list contains valid and invalid entities, the Server ignores   the invalid entities and returns results for the valid entities.   Invalid entities are entities that are not in the vCenter inventory. - If the list contains only datastores, the method throws   an &lt;code&gt;InvalidArgument&lt;/code&gt; fault.  | 
**Profile** | [**PbmProfileId**](PbmProfileId.md) | Not used. if specified, the Server ignores the value. The Server uses the profiles associated with the specified entities.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

