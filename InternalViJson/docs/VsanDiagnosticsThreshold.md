# Vcenter.ViJson.OpenApi.Model.VsanDiagnosticsThreshold

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The \&quot;entityType\&quot; is used to identify the target entity to get/set the threshold value.  Current supported entity types and metrics:   &lt;table cellspacing&#x3D;\&quot;0\&quot;&gt; &lt;tr&gt;&lt;th&gt;Entity Type&lt;/th&gt;&lt;th&gt;Metrics&lt;/th&gt;&lt;/tr&gt; &lt;tr&gt; &lt;td nowrap&#x3D;\&quot;1\&quot;&gt;&#39;vsan-pnic-net&#39;&lt;/td&gt; &lt;td&gt; &#39;rxCrcErr&#39;, &#39;txCarErr&#39;, &#39;rxErr&#39;, &#39;txErr&#39;, &#39;pauseCount&#39;, &#39;rxMissErr&#39;, &#39;rxOvErr&#39;, &#39;rxFifoErr&#39; &lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td nowrap&#x3D;\&quot;1\&quot;&gt;&#39;rdt-net&#39;&lt;/td&gt; &lt;td&gt; &#39;checksumMismatchCount&#39; &lt;/td&gt; &lt;/tr&gt; &lt;/table&gt;  | 
**Metric** | **string** | The \&quot;metric\&quot; is used to identify the stats of an entity, e.g.: rxCrcErr (CRC error of physical NIC), txCarErr (Carrier error of physical NIC).  Current supported metrics:   See *VsanDiagnosticsThreshold.entityType*  | 
**Yellow** | **int** | The yellow value of threshold indicates light severe warnings.  The unit is the same as the metric.  | [optional] 
**Red** | **int** | The red value of threshold indicates severe warnings.  The unit is the same as the metric.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

