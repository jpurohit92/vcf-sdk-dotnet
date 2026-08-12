# Vcenter.ViJson.OpenApi.Model.DVSTrafficShapingPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Inherited** | **bool** | Whether the configuration is set to inherited value.  | 
**Enabled** | [**BoolPolicy**](BoolPolicy.md) | The flag to indicate whether or not traffic shaper is enabled on the port.  | [optional] 
**AverageBandwidth** | [**LongPolicy**](LongPolicy.md) | The average bandwidth in bits per second if shaping is enabled on the port.  | [optional] 
**PeakBandwidth** | [**LongPolicy**](LongPolicy.md) | The peak bandwidth during bursts in bits per second if traffic shaping is enabled on the port.  | [optional] 
**BurstSize** | [**LongPolicy**](LongPolicy.md) | The maximum burst size allowed in bytes if shaping is enabled on the port.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

