# Vcenter.ViJson.OpenApi.Model.VsanClusterHealthCategoryEnumEnum
The vSAN cluster health category enumeration.  Each of non-green health check belongs to a specific category according to its actual user impact. The health score can be calculated based on it.  Possible values: - `DataAvailability`: The health category which impacts the vSAN object data availability and need user immediate action to avoid possible data loss. - `InfraAvailability`: The health category which impacts the vSAN cluster infrastructure availability like host/network/disk health.      Notice it may impact data availability eventually. - `DataPerformance`: The health category which impacts the vSAN object data performance like congestion health. - `InfraPerformance`: The health category which impacts the vSAN cluster infrastructure performance like network latency health.      Notice it may impact user data performance eventually. - `CapacityUtilization`: The health category which impacts the vSAN cluster capacity utilization. - `SoftResourceUtilization`: The health category which impacts the vSAN software resource utilization like component health. - `Compliance`: The health category of which health warning is not compliant with vSAN cluster requirement or recommendation.      Notice the health warnings in this category have no immediate impact for the current vSAN cluster but it may have potential risk with unpredictable impact in future. - `VsanClusterHealthCategoryEnum_Unknown` 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

