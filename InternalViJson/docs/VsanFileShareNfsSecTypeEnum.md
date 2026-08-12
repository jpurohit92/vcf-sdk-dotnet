# Vcenter.ViJson.OpenApi.Model.VsanFileShareNfsSecTypeEnum
Enumeration of the allowed NFS share security type.  This field is not applicable for SMB file share. Kerberos security types is based on following RFC: https://tools.ietf.org/html/rfc2203.  Possible values: - `SYS`: AUTH\\_SYS or unmanaged authentication from server.      Where server trust the uid/gid sent from clients and make no attemp to validate the same. - `KRB5`: RPCSEC\\_GSS None (Only Authentication) - `KRB5I`: RPCSEC\\_GSS Integrity (With checksum) - `KRB5P`: RPCSEC\\_GSS Privacy (With Encryption) - `FileShareNfsSecType_Unknown`: represent the value when the lower version client cannot recognize the enum value 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

