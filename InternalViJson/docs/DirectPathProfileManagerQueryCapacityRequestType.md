# Vcenter.ViJson.OpenApi.Model.DirectPathProfileManagerQueryCapacityRequestType
The parameters of *DirectPathProfileManager.DirectPathProfileManagerQueryCapacity*.  ***Since:*** vSphere API Release 9.0.0.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Target** | [**DirectPathProfileManagerTargetEntity**](DirectPathProfileManagerTargetEntity.md) | specifies the compute resource for which the capacity needs to be computed. See *DirectPathProfileManagerTargetEntity*. A null or an invalid target will cause an exception.  | 
**QuerySpec** | [**List&lt;DirectPathProfileManagerCapacityQuerySpec&gt;**](DirectPathProfileManagerCapacityQuerySpec.md) | specifies a list of *DirectPathProfileManagerCapacityQuerySpec*, where each of them specifies the information about the DirectPath profile for which capacity needs to be computed.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

