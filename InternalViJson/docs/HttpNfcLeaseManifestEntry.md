# Vcenter.ViJson.OpenApi.Model.HttpNfcLeaseManifestEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Key used to match this entry with the corresponding *HttpNfcLeaseDeviceUrl* entry in *HttpNfcLease.info*.  | 
**Sha1** | **string** | SHA-1 checksum of the data stream sent from the server.  This can be used to verify that the bytes received by the client match those sent by the HttpNfc server.  | 
**Checksum** | **string** | Checksum of the data stream sent/recieved by host.  See *HttpNfcLeaseManifestEntryChecksumType_enum* for used algorithm.  | [optional] 
**ChecksumType** | **string** | Algorithm used to produce checksum in respective property.  See *HttpNfcLeaseManifestEntryChecksumType_enum* for supported algorithms.  | [optional] 
**Size** | **long** | Size of the downloaded file.  | 
**Disk** | **bool** | True if the downloaded file is a virtual disk backing.  | 
**Capacity** | **long** | The capacity of the disk, if the file is a virtual disk backing.  | [optional] 
**PopulatedSize** | **long** | The populated size of the disk, if the file is a virtual disk backing.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

