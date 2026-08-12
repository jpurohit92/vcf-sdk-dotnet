# Vcenter.ViJson.OpenApi.Model.VsanClusterHealthAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionId** | **string** | The unique action ID  See also *VsanClusterHealthActionIdEnum_enum*.  | 
**ActionLabel** | [**LocalizableMessage**](LocalizableMessage.md) | The action label showing in UI  | 
**ActionDescription** | [**LocalizableMessage**](LocalizableMessage.md) | The action description  | 
**Enabled** | **bool** | True indicates the action will be enabled and vSphere/storage admin can perform the remediation operation to resolve the health issue, but it&#39;s not always appropriate to trigger such operation and user need to use judgment of the situation to decide.  | 
**Parameters** | [**List&lt;KeyValue&gt;**](KeyValue.md) | The action parameters which can be used as the parameters for this action API when calling from UI.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

