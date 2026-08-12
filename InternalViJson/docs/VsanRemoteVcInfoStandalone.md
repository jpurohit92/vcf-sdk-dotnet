# Vcenter.ViJson.OpenApi.Model.VsanRemoteVcInfoStandalone

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LinkType** | **string** | The link type about how the remote vCenter is linked.  It can be optional for *VsanRemoteDatastoreSystem.VsanUpdateDatastoreSource* and *VsanRemoteDatastoreSystem.VsanDestroyDatastoreSource* APIs.  See also *VsanRemoteVcLinkType_enum*.  | [optional] 
**VcHost** | **string** | The remote vCenter name (e.g.  FQDN) to identify the remote vCenter.  | 
**User** | **string** | The user name for login into the standalone remote vCenter.  This information won&#39;t be persisted in backend implementation.  | [optional] 
**Password** | **string** | The password for login into the standalone remote vCenter.  This information won&#39;t be persisted in backend implementation.  | [optional] 
**Cert** | **string** | The single x509 certificate encoded in PEM format, which the remote vCenter is expected to have.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

