# Vcenter.Automation.OpenApi.Model.VcenterVmGuestFilesystemFilesIterationSpec
The Vcenter.Vm.Guest.Filesystem.Files.IterationSpec schema contains properties used to break results into pages when listing files. See *POST /vcenter/vm/{vm}/guest/filesystem/files?action=list*).  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Size** | **long** | Specifies the maximum number of results to return.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; information about at most 50 files will be returned. | [optional] 
**Index** | **long** | Which result to start the list with. If this value exceeds the number of results, an empty list will be returned.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60;, the start of the list of files will be returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

