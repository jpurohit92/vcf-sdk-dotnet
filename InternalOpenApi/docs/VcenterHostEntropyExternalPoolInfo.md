# Vcenter.Automation.OpenApi.Model.VcenterHostEntropyExternalPoolInfo
The Vcenter.Host.Entropy.ExternalPool.Info schema contains entropy pool information on the ESX host. It provides external entropy pool details as well as timeout in seconds within which client has to keep calling *GET /vcenter/host/{host}/entropy/external-pool* operation.    Client has to monitor Info.currentlyAvailable parameter. Before the entropy level goes down below a threshold value the client has to send entropy data by calling *POST /vcenter/host/{host}/entropy/external-pool?action=add* operation.  This schema was added in __vSphere API 8.0.1.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | This flag indicates entropy service is enabled or not in a ESX host.  Possible values:   - &#x60;ENABLED&#x60;: External entropy is enabled for the ESX host.   - &#x60;DISABLED&#x60;: External entropy is disabled for the ESX host.   For more information see: *Vcenter.Host.Entropy.ExternalPool.Status*.  This property was added in __vSphere API 8.0.1.0__. | 
**Capacity** | **long** | Capacity of external entropy pool in bytes.  This property was added in __vSphere API 8.0.1.0__.  This property is optional and it is only relevant when the value of status is *Vcenter.Host.Entropy.ExternalPool.Status.ENABLED*. | [optional] 
**CurrentlyAvailable** | **long** | Currently available amount of entropy in bytes in the external entropy pool.  This property was added in __vSphere API 8.0.1.0__.  This property is optional and it is only relevant when the value of status is *Vcenter.Host.Entropy.ExternalPool.Status.ENABLED*. | [optional] 
**LowWatermark** | **long** | A threshold value in bytes. An audit record will be logged when *Vcenter.Host.Entropy.ExternalPool.Info.currently_available* drops below this value.  This property was added in __vSphere API 8.0.1.0__.  This property is optional and it is only relevant when the value of status is *Vcenter.Host.Entropy.ExternalPool.Status.ENABLED*. | [optional] 
**InactiveSourceTimeout** | **long** | A timeout period in seconds within which the client must call *GET /vcenter/host/{host}/entropy/external-pool* operation or *POST /vcenter/host/{host}/entropy/external-pool?action&#x3D;add* operation. If no call is received before the timeout lapses an audit record will be created.    This timeout is used to detect that connection with the client is lost.  This property was added in __vSphere API 8.0.1.0__.  This property is optional and it is only relevant when the value of status is *Vcenter.Host.Entropy.ExternalPool.Status.ENABLED*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

