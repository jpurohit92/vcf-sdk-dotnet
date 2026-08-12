# Vcenter.ViJson.OpenApi.Model.StorageContainer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | Unique identifier  | 
**Name** | **string** | Name of the container  | 
**MaxVvolSizeInMB** | **long** | Maximum allowed capacity of the Virtual Volume in MBs  | 
**ProviderId** | **List&lt;string&gt;** | *SmsProviderInfo.uid* for providers that reports the storage container.  | 
**ArrayId** | **List&lt;string&gt;** |  | 
**VvolContainerType** | **string** | Represents type of VVOL container, the supported values are listed in *StorageContainerVvolContainerTypeEnum_enum*.  If the storage array is not capable of supporting mixed PEs for a storage container, the VVOL VASA provider sets this property to the supported endpoint type  | [optional] 
**Stretched** | **bool** | Indicates if this storage container is stretched  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

