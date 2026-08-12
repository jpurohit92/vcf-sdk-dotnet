# Vcenter.ViJson.OpenApi.Model.HostMultipathInfoFixedLogicalUnitPolicy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Policy** | **string** | String representing the path selection policy for a device.  Use one of the following strings: For NMP plugin - &lt;code&gt;VMW\\_PSP\\_FIXED&lt;/code&gt; - Use a preferred path whenever possible. - &lt;code&gt;VMW\\_PSP\\_RR&lt;/code&gt; - Load balance. - &lt;code&gt;VMW\\_PSP\\_MRU&lt;/code&gt; - Use the most recently used path.    For HPP plugin - &lt;code&gt;FIXED&lt;/code&gt; - Use a preferred path whenever possible. - &lt;code&gt;LB-RR&lt;/code&gt; - Load Balance - round robin. - &lt;code&gt;LB-IOPS&lt;/code&gt; - Load Balance - iops. - &lt;code&gt;LB-BYTES&lt;/code&gt; - Load Balance - bytes. - &lt;code&gt;LB- -Latency&lt;/code&gt; - Load balance - least latency.    You can also use the *HostStorageSystem.QueryPathSelectionPolicyOptions* method to retrieve the set of valid strings. Use the key from the resulting structure *HostPathSelectionPolicyOption*.  | 
**Prefer** | **string** | Preferred path used for the **fixed** policy.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

