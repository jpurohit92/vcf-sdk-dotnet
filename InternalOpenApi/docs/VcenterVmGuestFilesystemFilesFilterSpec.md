# Vcenter.Automation.OpenApi.Model.VcenterVmGuestFilesystemFilesFilterSpec
The Vcenter.Vm.Guest.Filesystem.Files.FilterSpec schema contains information used to filter the results when listing files (see *POST /vcenter/vm/{vm}/guest/filesystem/files?action=list*).  This schema was added in __vSphere API 7.0.2.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MatchPattern** | **string** | The perl-compatible regular expression used to filter the returned files.  This property was added in __vSphere API 7.0.2.0__.  If missing or &#x60;null&#x60; the pattern __&#39;.*&#39;__ (match everything) is used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

