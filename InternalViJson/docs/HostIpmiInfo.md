# Vcenter.ViJson.OpenApi.Model.HostIpmiInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BmcIpAddress** | **string** | IP address of the BMC on the host.  It should be null terminated.  | [optional] 
**BmcMacAddress** | **string** | MAC address of the BMC on the host.  The MAC address should be of the form xx:xx:xx:xx:xx:xx where each x is a hex digit. It should be null terminated.  | [optional] 
**Login** | **string** | User ID for logging into the BMC.  BMC usernames may be up to 16 characters and must be null terminated. Hence, a login comprises 17 or fewer characters.  | [optional] 
**Password** | **string** | Password for logging into the BMC.  Only used for configuration, returned as unset while reading. The password can be up to 16 characters and must be null terminated. Hence, a password comprises 17 or fewer characters.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

