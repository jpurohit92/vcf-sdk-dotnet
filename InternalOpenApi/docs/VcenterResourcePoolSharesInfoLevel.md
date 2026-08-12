# Vcenter.Automation.OpenApi.Model.VcenterResourcePoolSharesInfoLevel
The Vcenter.ResourcePool.SharesInfo.Level enumerated type defines the possible values for the allocation level.  Possible values:   - `LOW`: For CPU: Shares = 500 * number of virtual CPUs.    For Memory: Shares = 5 * virtual machine memory size in MB.      - `NORMAL`: For CPU: Shares = 1000 * number of virtual CPUs.    For Memory: Shares = 10 * virtual machine memory size in MB.      - `HIGH`: For CPU: Shares = 2000 * number of virtual CPUs.    For Memory: Shares = 20 * virtual machine memory size in MB.      - `CUSTOM`: If set, in case there is resource contention the server uses the shares value to determine the resource allocation.   This enumeration was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

