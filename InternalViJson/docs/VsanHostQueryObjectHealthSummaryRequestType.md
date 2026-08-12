# Vcenter.ViJson.OpenApi.Model.VsanHostQueryObjectHealthSummaryRequestType
The parameters of *HostVsanHealthSystem.VsanHostQueryObjectHealthSummary*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjUuids** | **List&lt;string&gt;** | The DOM object UUID list to be queried. None to query all of objects  | [optional] 
**IncludeObjUuids** | **bool** | True to include the object UUID list in the returned list and default is False  | [optional] 
**LocalHostOnly** | **bool** | True to only query the objects owned by the host and default is False  | [optional] 
**IncludeNonComplianceObjDetail** | **bool** | True to include all of non-compliant objects detail information. The default is False  | [optional] 
**Spec** | [**VsanHealthQuerySpec**](VsanHealthQuerySpec.md) | The additional query spec for object health. If the object health version is v2 *VsanObjectHealthVersion_enum*, it will try to convert v1 to v2 if not all of host can support the new object health version. If the object health version is unknown, it will always try to return the v2 object health version if all hosts support or return v1 if it doesn&#39;t  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

