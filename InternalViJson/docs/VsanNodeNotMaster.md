# Vcenter.ViJson.OpenApi.Model.VsanNodeNotMaster

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VsanMasterUuid** | **string** | The vSAN Node UUID of the Master.  May be itself, in which case this means that the node is CMMDS master, but can&#39;t act in the master role for the operation in question. See other fields for possible reasons.  | [optional] 
**CmmdsMasterButNotStatsMaster** | **bool** | If true, it means this node is CMMDS master, but is currently not Stats master.  This could be because it is in the process of becoming stats master, or because it failed to become stats master, e.g. due to the object being inaccessible.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

