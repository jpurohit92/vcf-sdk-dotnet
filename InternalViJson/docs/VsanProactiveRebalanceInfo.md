# Vcenter.ViJson.OpenApi.Model.VsanProactiveRebalanceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Whether proactive rebalance is enabled.  If it is set to True, rebalance data movement will begin when following conditions are met within vSAN cluster, 1\\. Current disk fullness - lowest disk fullness &amp;gt; proactive threshold 2\\. Current disk fullness &amp;gt; mean disk fulless within cluster - Allowed values:   True if proactive rebalance is enabled;   False if proactive rebalance is disabled. - Default value: False  | [optional] 
**Threshold** | **int** | Proactive relalance threshold.  It indicates the extent of the imbalance the cluster can tolerate in percentage. If the disk imbalance (current disk fullness - lowest disk fullness) is below rebalance threshold, the proactive rebalance will not be triggered. - Allowed values: 10 to 75. - Default value: 30.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

