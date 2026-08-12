# Vcenter.ViJson.OpenApi.Model.DirectPathProfileManagerCapacityInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | [**DirectPathProfileInfo**](DirectPathProfileInfo.md) | Detailed information of the DirectPath profile.  See *DirectPathProfileInfo*.  | 
**Consumed** | **int** | Number of DirectPath profile units consumed by the powered-on VMs on the *DirectPathProfileManagerTargetEntity*.  | 
**Remaining** | **int** | Number of DirectPath profile units that are remaining and have not yet been assigned to any powered-on VM on the *DirectPathProfileManagerTargetEntity*.  | 
**Max** | **int** | The total capacity of DirectPath profile in the *DirectPathProfileManagerTargetEntity*.  The total capacity of a profile is computed in a theoretical condition when no VM is running on the *DirectPathProfileManagerTargetEntity*. In addition, this capacity doesn&#39;t include the capacity consumed by vSphere&#39;s system components.  | 
**UnusedReservation** | **int** | Number of DirectPath profile units that are reserved but have not yet been assigned to any powered-on VM.  These units can be used to power-on VMs for which the capacity has been reserved. This is different from remaining capacity because this capacity is actually reserved but just unused by any VM whereas remaining capacity indicates what has not even been reserved either. For any given DirectPath profile, we will always have the constraint: max &amp;gt;&#x3D; consumed + remaining + unusedReservation  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

