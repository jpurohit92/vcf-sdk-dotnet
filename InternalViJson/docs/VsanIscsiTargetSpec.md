# Vcenter.ViJson.OpenApi.Model.VsanIscsiTargetSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthSpec** | [**VsanIscsiTargetAuthSpec**](VsanIscsiTargetAuthSpec.md) | Authentication information.  | [optional] 
**Port** | **int** | The network port on which target is accessible.  If not specified, at the same time, if networkInterface is also not specified, defaults to the defaultPort specified in iSCSI target service. If networkInterface is specified, defaults to port 3260. The firewall should be opened automatically for port specified by the user.  | [optional] 
**NetworkInterface** | **string** | Name of the VMkernel Network interface which will handle the iSCSI traffic.  If not specified, the default one defined in iSCSI target service will be used.  | [optional] 
**AffinityLocation** | **string** | The site affinity location option is only available when the cluster is configured into the streched cluster mode.  No site affinity will be configured when this field is not present.  See also *VsanSiteLocationType_enum*.  | [optional] 
**StoragePolicy** | [**VirtualMachineProfileSpec**](VirtualMachineProfileSpec.md) | Storage policy used by this target.  If not specified, the vSAN datastore vmnamespace policy should be used by default.  | [optional] 
**NewAlias** | **string** | The new alias for the iSCSI target.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

