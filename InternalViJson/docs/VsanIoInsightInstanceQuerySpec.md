# Vcenter.ViJson.OpenApi.Model.VsanIoInsightInstanceQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | Indicate the state in which ioinsight instance will be returned.  If this attribute is not provided, ioinsight instance state will be skipped during the query operation.  See also *VsanIoInsightInstanceState_enum*.  | [optional] 
**EntityRefId** | **string** | The &#39;entityRefId&#39; is a reference id of the target entity, which acts as filter condition for ioinsight instance query.  For example, if host entity is provided then the query operation will return all ioinsight instances containing the host. If this attribute is not provided, the query operation will return all ioinsight instances matching *VsanIoInsightInstanceQuerySpec.state* The reference id consists of entity type and ID, which is formated as &amp;lt;entity-type&amp;gt;:&amp;lt;entity-id&amp;gt; Below are the examples: &lt;table cellspacing&#x3D;\&quot;0\&quot;&gt; &lt;tr&gt; &lt;th&gt;Entity Type&lt;/th&gt; &lt;th&gt;Entity ID format&lt;/th&gt; &lt;th&gt;EntityRefId Example&lt;/th&gt; &lt;tr&gt; &lt;td&gt;Host&lt;/td&gt; &lt;td&gt;Host UUID&lt;/td&gt; &lt;td&gt;&#39;host:xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx&#39;&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;VM&lt;/td&gt; &lt;td&gt;VM InstanceUUID&lt;/td&gt; &lt;td&gt;&#39;vm:xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx&#39;&lt;/td&gt; &lt;/tr&gt; &lt;tr&gt; &lt;td&gt;runName&lt;/td&gt; &lt;td&gt;IOInsight runName&lt;/td&gt; &lt;td&gt;&#39;runName:xxxxxx&#39;&lt;/td&gt; &lt;/tr&gt; &lt;/table&gt;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

