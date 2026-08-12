# Vcenter.ViJson.OpenApi.Model.VimVsanHostTrafficTypeEnum
Network transmission type of vSAN traffic through a virtual network adapter for 8.x and previous releases.  Possible values: - `vsan`: This vmknic is used for general vSAN data transmission.      If no vSAN vmknic configured with 'witness' traffic type, witness data transmission will be handled by vmknic with 'vsan' traffic type. - `witness`: This vmknic is dedicated for vSAN witness data transmission.      For vSAN stretched cluster, this traffic type is recommended for vSAN vmknics to be used for witness transmission. - `TrafficType_Unknown` 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

