# Vcenter.ViJson.OpenApi.Model.VsanDataEfficiencyConfigEx

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DedupEnabled** | **bool** | Enables data deduplication and compression on the vSAN cluster.  The behaviour of this flag is described in the table above.  | 
**CompressionEnabled** | **bool** | Enables compression on the vSAN cluster.  For vSAN OSA, the behaviour of this flag is the same as compressionEnabled in the table above. For vSAN ESA, compression is enabled by default since 9.1.0 release, disabling compression is not supported.  | [optional] 
**DedupStoreUuid** | **string** | The UUID of the global deduplication store that is used to store deduplicated data.  Do not set this field when enabling global deduplication because this field will be generated automatically by vSAN. There is rare use case to put a valid global deduplication store uuid here, for example, when restoring configuration for the cluster from existing running hosts.  | [optional] 
**DedupPaused** | **bool** | Pause/continue the data deduplication service.  Deduplication configurations work together as below. &lt;table cellspacing&#x3D;\&quot;0\&quot;&gt; &lt;tr&gt; &lt;th&gt;dedupEnabled&lt;/th&gt; &lt;th&gt;dedupPaused&lt;/th&gt; &lt;th&gt;Details&lt;/th&gt; &lt;th&gt;State Transition&lt;/th&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;1 or 0&lt;/td&gt; &lt;td&gt;1&lt;/td&gt; &lt;td&gt; - Pause the deduplication service if already enabled, it only applies to vSAN ESA - Stop to enable the deduplication service if not enabled, it only applies to vSAN ESA    &lt;/td&gt; &lt;td&gt; - Deduplication enabled -&amp;gt; Deduplication service paused - Deduplication not initialized -&amp;gt; Deduplication service paused     &lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;1 or 0&lt;/td&gt; &lt;td&gt;0&lt;/td&gt; &lt;td&gt; - Continue the ESA deduplication service if already enabled, it only applies to vSAN ESA - Restart to enable the deduplication service if not enabled, it only applies to vSAN ESA    &lt;/td&gt; &lt;td&gt; - Deduplication service paused -&amp;gt; Deduplication enabled - Deduplication service paused -&amp;gt; Deduplication initialization     &lt;/td&gt; &lt;/tr&gt; &lt;/table&gt;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

