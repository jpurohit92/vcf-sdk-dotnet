# Vcenter.ViJson.OpenApi.Model.DvsHostVNicProfile
The *DvsHostVNicProfile* data object describes the IP configuration for a host Virtual NIC connected to a distributed virtual switch.  The *DvsVNicProfile.ipConfig* property contains the Virtual NIC IP address. If a profile plug-in defines policies or subprofiles, use the *ApplyProfile.policy* or *ApplyProfile.property* list to access the additional configuration data. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Linkable identifier.  | 
**IpConfig** | [**IpAddressProfile**](IpAddressProfile.md) | IP address for the Virtual NIC belonging to a distributed virtual switch.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

