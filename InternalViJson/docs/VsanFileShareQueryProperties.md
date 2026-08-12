# Vcenter.ViJson.OpenApi.Model.VsanFileShareQueryProperties

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncludeBasic** | **bool** | Basic share properties include all properties for a file share, except \\#labels, \\#usedCapacity and \\#vsanObjectUuids.  The default value is True.  | [optional] 
**IncludeUsedCapacity** | **bool** | Specify whether to return #usedCapacity property of the share.  The default value is False.  | [optional] 
**IncludeVsanObjectUuids** | **bool** | Specify whether to return #vsanObjectUuids property of the share.  The default value is False.  | [optional] 
**IncludeAllLabels** | **bool** | Specify whether to return #labels property of the share.  The default value is False. If this field is True, all share labels will be returned.  | [optional] 
**LabelKeys** | **List&lt;string&gt;** | Specify the label keys to be returned.  This field will be ignored if *VsanFileShareQueryProperties.includeAllLabels* is set to True. If a label key does not exist in a share, the label will not be returned with the share. An InvalidArgument will be thrown if the number of label keys exceeds 5.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

