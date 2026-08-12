# Vcenter.ViJson.OpenApi.Model.PbmServerObjectRef

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | **string** | Type of vSphere Server object.  The value of the &lt;code&gt;objectType&lt;/code&gt; string corresponds to one of the *PbmObjectType_enum* enumerated type values.  | 
**Key** | **string** | Unique identifier for the object.  The value of &lt;code&gt;key&lt;/code&gt; depends on the &lt;code&gt;objectType&lt;/code&gt;.       &lt;table border&#x3D;\&quot;1\&quot;cellpadding&#x3D;\&quot;5\&quot;&gt; &lt;tr&gt;&lt;td&gt;**PbmObjectType**&lt;/td&gt;&lt;td&gt;**key value**&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;virtualMachine&lt;/td&gt;&lt;td&gt;_virtual-machine-MOR_&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;virtualDiskId&lt;/td&gt; &lt;td&gt;_virtual-disk-MOR_:_VirtualDisk.key_&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td&gt;datastore&lt;/td&gt;&lt;td&gt;_datastore-MOR_&lt;/td&gt;&lt;/tr&gt; &lt;tr&gt;&lt;td colspan&#x3D;\&quot;2\&quot;align&#x3D;\&quot;right\&quot;&gt;MOR &#x3D; ManagedObjectReference&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt;  | 
**ServerUuid** | **string** | vCenter Server UUID; the &lt;code&gt;ServiceContent.about.instanceUuid&lt;/code&gt; property in the vSphere API.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

