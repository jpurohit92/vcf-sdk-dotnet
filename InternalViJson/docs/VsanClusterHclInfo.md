# Vcenter.ViJson.OpenApi.Model.VsanClusterHclInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HclDbLastUpdate** | **DateTime** | The time (UTC time) from when the currently used HCL DB was known to be the latest up-to-date version.  | [optional] 
**HclDbAgeHealth** | **string** | The age health of the HCL DB.  If older than 90 days, state is yellow. If older than 180 days, it is red. If no age known, state is \&quot;unknown\&quot;.  | [optional] 
**HostResults** | [**List&lt;VsanHostHclInfo&gt;**](VsanHostHclInfo.md) | HCL status of each host.  | [optional] 
**UpdateItems** | [**List&lt;VsanUpdateItem&gt;**](VsanUpdateItem.md) | List of things (firmwares, drivers, VIBs, etc.) recommended to be installed on the cluster.  Each item in the list applies to a specific host, as not all hosts are assumed to be at the same level. This field is only populated if explicitly requested.  | [optional] 
**HclDbAbsent** | **bool** | True indicates the vSAN HCL DB is absent so that the HCL validation is not able to be performed.  To resolve the issue, please check vSAN Health UI.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

