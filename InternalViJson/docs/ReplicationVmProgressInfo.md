# Vcenter.ViJson.OpenApi.Model.ReplicationVmProgressInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Progress** | **int** | An estimation of the operation progress as a percentage completed, from 0 to 100.  | 
**BytesTransferred** | **long** | Number of bytes transferred so far.  For sync operations, this value includes (i.e. counts multiple times) areas that were transferred multiple times (due to stopping and continuing the operation, or for some errors).  | 
**BytesToTransfer** | **long** | The total number of bytes to be transferred.  For lwd operations, this is the total size of the disk images that are transferring. This is known from the start and will not change during a lwd operation.  For sync operations, this is the total size of the blocks that have been found not to match between the primary and secondary (by comparing checksums). It starts from 0 and grows as the checksum operations advance. The value includes (i.e. counts multiple times) areas that will end up being transferred more than once (due to stopping and continuing the operation, or for some errors).  | 
**ChecksumTotalBytes** | **long** | The total number of bytes to be checksummed, only present for sync tasks.  This is the total size of all disks.  | [optional] 
**ChecksumComparedBytes** | **long** | The total number of bytes that were checksummed, only present for sync tasks.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

