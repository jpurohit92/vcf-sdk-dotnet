# Vcenter.ViJson.OpenApi.Model.HostDiskPartitionSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PartitionFormat** | **string** | Partition format type on the disk.  | [optional] 
**Chs** | [**HostDiskDimensionsChs**](HostDiskDimensionsChs.md) | Disk dimensions expressed as cylinder, head, sector (CHS) coordinates.  | [optional] 
**TotalSectors** | **long** | Disk dimensions expressed as a total number of sectors.  For sector size, see the *HostDiskPartitionSpec.sectorSize* field.  | [optional] 
**Partition** | [**List&lt;HostDiskPartitionAttributes&gt;**](HostDiskPartitionAttributes.md) | List of partitions on the disk.  | [optional] 
**SectorSize** | **int** | The sector size in bytes.  The typical values are 512 and 4096. If unset, the value should be considered 512.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

