# Vcenter.Automation.OpenApi.Model.VcenterResourcePoolSharesInfo
The Vcenter.ResourcePool.SharesInfo schema provides specification of shares.    Shares are used to determine relative allocation between resource consumers. In general, a consumer with more shares gets proportionally more of the resource, subject to certain other constraints.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Level** | **string** | The allocation level. It maps to a pre-determined set of numeric values for shares. If the shares value does not map to a predefined size, then the level is set as CUSTOM.  Possible values:   - &#x60;LOW&#x60;: For CPU: Shares &#x3D; 500 * number of virtual CPUs.    For Memory: Shares &#x3D; 5 * virtual machine memory size in MB.      - &#x60;NORMAL&#x60;: For CPU: Shares &#x3D; 1000 * number of virtual CPUs.    For Memory: Shares &#x3D; 10 * virtual machine memory size in MB.      - &#x60;HIGH&#x60;: For CPU: Shares &#x3D; 2000 * number of virtual CPUs.    For Memory: Shares &#x3D; 20 * virtual machine memory size in MB.      - &#x60;CUSTOM&#x60;: If set, in case there is resource contention the server uses the shares value to determine the resource allocation.   For more information see: *Vcenter.ResourcePool.SharesInfo.Level*.  This property was added in __vSphere API 7.0.0.0__. | 
**Shares** | **long** | When *Vcenter.ResourcePool.SharesInfo.level* is set to CUSTOM, it is the number of shares allocated. Otherwise, this value is ignored.    There is no unit for this value. It is a relative measure based on the settings for other resource pools.  This property was added in __vSphere API 7.0.0.0__.  This property is optional and it is only relevant when the value of level is *Vcenter.ResourcePool.SharesInfo.Level.CUSTOM*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

