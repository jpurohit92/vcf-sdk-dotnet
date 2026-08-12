# Vcenter.ViJson.OpenApi.Model.VsanObjectHealth

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumObjects** | **int** | Number of objects that have this health status.  | 
**Health** | **string** | The vSAN object health state  See also *VsanObjectHealthState_enum*.  | [optional] 
**ObjUuids** | **List&lt;string&gt;** | Object UUIDs of objects that have this health status.  Only included if query API requested it due to size.  | [optional] 
**VsanClusterUuid** | **string** | The vSAN cluster UUID where the objects are created from It will be local vSAN datastore If it&#39;s not set  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

