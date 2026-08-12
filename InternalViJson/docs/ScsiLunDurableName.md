# Vcenter.ViJson.OpenApi.Model.ScsiLunDurableName

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Namespace** | **string** | The string describing the namespace used for the durable name.  | 
**NamespaceId** | **int** | The byte used by the ESX Server product to represent the namespace.  | 
**Data** | **List&lt;int&gt;** | The variable length byte array containing the namespace-specific data.  For a SCSI-3 compliant device this field is the descriptor header along with the payload for data obtained from page 83h, and is the payload for data obtained from page 80h of the Vital Product Data (VPD).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

