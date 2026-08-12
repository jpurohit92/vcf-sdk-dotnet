# Vcenter.ViJson.OpenApi.Model.VsanPerfNodeInformation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | vSAN performance service version.  | 
**Hostname** | **string** | Name of the host.  Only set if queried via vCenter  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | If error is set, it means that collection of node information failed.  | [optional] 
**IsCmmdsMaster** | **bool** | Whether or not the node is CMMDS Master.  | 
**IsStatsMaster** | **bool** | Whether or not the node is Stats Master.  | 
**VsanMasterUuid** | **string** | The vSAN Node UUID of the CMMDS Master.  May be itself.  | [optional] 
**VsanNodeUuid** | **string** | The vSAN Node UUID of the node being queried  | [optional] 
**MasterInfo** | [**VsanPerfMasterInformation**](VsanPerfMasterInformation.md) | Additional information in case the node is a stats master.  | [optional] 
**DiagnosticMode** | **bool** | Whether the node has diagnostic mode enabled.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

