# Vcenter.ViJson.OpenApi.Model.PerfProviderSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the performance provider, the *managed object* that provides real-time or historical metrics.  The managed objects include but are not limited to *managed entities*, such as *host systems*, *virtual machines*, and *resource pools*.  | 
**CurrentSupported** | **bool** | True if this entity supports real-time (current) statistics; false if it does not.  If this property is true for an entity, a client application can set the *PerfQuerySpec.intervalId* of the *PerfQuerySpec* (passed to the *PerformanceManager.QueryPerf* operation) to the *PerfProviderSummary.refreshRate* to obtain the maximum information possible for the entity.  | 
**SummarySupported** | **bool** | True if this entity supports historical (aggregated) statistics; false if it does not.  When this property is true for an entity, a client application can set the *PerfQuerySpec.intervalId* of *PerformanceManager.QueryPerf* to one of the historical *intervals* to obtain historical statistics for this entity.  | 
**RefreshRate** | **int** | Number of seconds between the generation of each counter.  This value applies only to entities that support real-time (current) statistics&amp;#46;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

