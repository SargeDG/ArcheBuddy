using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Xml.Linq;
using ArcheBuddy;
using ArcheBuddy.Bot.Classes;
using ArcheBuddy.WPFForms;
using Buddy.Store;
using MahApps.Metro.Controls;
using Microsoft.VisualBasic.FileIO;
using Selen.Wpf.SystemStyles.Actions;

namespace A
{
	// Token: 0x02000128 RID: 296
	internal sealed class cbf4111912aed594f2b4372828dd95aa3 : MetroWindow, IComponentConnector
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x000551D4 File Offset: 0x000533D4
		public cbf4111912aed594f2b4372828dd95aa3()
		{
			c84941c318814778ec06c2a3b9d3a2d57.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			MemoryStream memoryStream = new MemoryStream();
			cc69bb88c75964e01f1ca2beabfaa629b.c30767ddca1f9c207888833aea5b5fc61(c1d7f442d2f0ad25026f5c070707c0302.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), memoryStream, c66cdf8f359ad723e1140c64687224d7a.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.ce89a1360461e96761b4795a70dac68e0 = new BitmapImage();
			c9658151ce19e5e1d823834689c70b814.c30767ddca1f9c207888833aea5b5fc61(this.ce89a1360461e96761b4795a70dac68e0);
			c82e5ef82e3184dc0f741b8f40eeb8743.c30767ddca1f9c207888833aea5b5fc61(memoryStream, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21476), (SeekOrigin)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21480));
			c651e483dbb48d33f4c26fdea0fcdfb47.c30767ddca1f9c207888833aea5b5fc61(this.ce89a1360461e96761b4795a70dac68e0, memoryStream);
			cdf04d684c74310f6b407692022abceed.c30767ddca1f9c207888833aea5b5fc61(this.ce89a1360461e96761b4795a70dac68e0);
			memoryStream = new MemoryStream();
			cc69bb88c75964e01f1ca2beabfaa629b.c30767ddca1f9c207888833aea5b5fc61(ca0eab930d08eeff99f0556bc42ab8126.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), memoryStream, c66cdf8f359ad723e1140c64687224d7a.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c07a8d858e311edb907a0f502c43ccf29 = new BitmapImage();
			c9658151ce19e5e1d823834689c70b814.c30767ddca1f9c207888833aea5b5fc61(this.c07a8d858e311edb907a0f502c43ccf29);
			c82e5ef82e3184dc0f741b8f40eeb8743.c30767ddca1f9c207888833aea5b5fc61(memoryStream, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21484), (SeekOrigin)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21488));
			c651e483dbb48d33f4c26fdea0fcdfb47.c30767ddca1f9c207888833aea5b5fc61(this.c07a8d858e311edb907a0f502c43ccf29, memoryStream);
			cdf04d684c74310f6b407692022abceed.c30767ddca1f9c207888833aea5b5fc61(this.c07a8d858e311edb907a0f502c43ccf29);
			memoryStream = new MemoryStream();
			cc69bb88c75964e01f1ca2beabfaa629b.c30767ddca1f9c207888833aea5b5fc61(cd0fe3021d6f071ca10bc689afc7081e0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), memoryStream, c66cdf8f359ad723e1140c64687224d7a.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.cd3c715e925438a82244546a84bd24ade = new BitmapImage();
			c9658151ce19e5e1d823834689c70b814.c30767ddca1f9c207888833aea5b5fc61(this.cd3c715e925438a82244546a84bd24ade);
			c82e5ef82e3184dc0f741b8f40eeb8743.c30767ddca1f9c207888833aea5b5fc61(memoryStream, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21492), (SeekOrigin)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21496));
			c651e483dbb48d33f4c26fdea0fcdfb47.c30767ddca1f9c207888833aea5b5fc61(this.cd3c715e925438a82244546a84bd24ade, memoryStream);
			cdf04d684c74310f6b407692022abceed.c30767ddca1f9c207888833aea5b5fc61(this.cd3c715e925438a82244546a84bd24ade);
			memoryStream = new MemoryStream();
			cc69bb88c75964e01f1ca2beabfaa629b.c30767ddca1f9c207888833aea5b5fc61(c3c5916e9d05b4272415d806ebc7223a4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), memoryStream, c66cdf8f359ad723e1140c64687224d7a.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.cb9bcf976186c79f4c709eebcd63eda46 = new BitmapImage();
			c9658151ce19e5e1d823834689c70b814.c30767ddca1f9c207888833aea5b5fc61(this.cb9bcf976186c79f4c709eebcd63eda46);
			c82e5ef82e3184dc0f741b8f40eeb8743.c30767ddca1f9c207888833aea5b5fc61(memoryStream, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21500), (SeekOrigin)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21504));
			c651e483dbb48d33f4c26fdea0fcdfb47.c30767ddca1f9c207888833aea5b5fc61(this.cb9bcf976186c79f4c709eebcd63eda46, memoryStream);
			cdf04d684c74310f6b407692022abceed.c30767ddca1f9c207888833aea5b5fc61(this.cb9bcf976186c79f4c709eebcd63eda46);
			memoryStream = new MemoryStream();
			cc69bb88c75964e01f1ca2beabfaa629b.c30767ddca1f9c207888833aea5b5fc61(c019d996faef4ec2e5313324d69b95363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), memoryStream, c66cdf8f359ad723e1140c64687224d7a.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c9a1aad0eb9412e7785834b30ef2fef12 = new BitmapImage();
			c9658151ce19e5e1d823834689c70b814.c30767ddca1f9c207888833aea5b5fc61(this.c9a1aad0eb9412e7785834b30ef2fef12);
			c82e5ef82e3184dc0f741b8f40eeb8743.c30767ddca1f9c207888833aea5b5fc61(memoryStream, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21508), (SeekOrigin)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21512));
			c651e483dbb48d33f4c26fdea0fcdfb47.c30767ddca1f9c207888833aea5b5fc61(this.c9a1aad0eb9412e7785834b30ef2fef12, memoryStream);
			cdf04d684c74310f6b407692022abceed.c30767ddca1f9c207888833aea5b5fc61(this.c9a1aad0eb9412e7785834b30ef2fef12);
			memoryStream = new MemoryStream();
			cc69bb88c75964e01f1ca2beabfaa629b.c30767ddca1f9c207888833aea5b5fc61(c983ae8bfbd96bfdb38df62b10e9d2058.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), memoryStream, c66cdf8f359ad723e1140c64687224d7a.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.cfb755cb93a73f30822ce601a125376d8 = new BitmapImage();
			c9658151ce19e5e1d823834689c70b814.c30767ddca1f9c207888833aea5b5fc61(this.cfb755cb93a73f30822ce601a125376d8);
			c82e5ef82e3184dc0f741b8f40eeb8743.c30767ddca1f9c207888833aea5b5fc61(memoryStream, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21516), (SeekOrigin)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21520));
			c651e483dbb48d33f4c26fdea0fcdfb47.c30767ddca1f9c207888833aea5b5fc61(this.cfb755cb93a73f30822ce601a125376d8, memoryStream);
			cdf04d684c74310f6b407692022abceed.c30767ddca1f9c207888833aea5b5fc61(this.cfb755cb93a73f30822ce601a125376d8);
			memoryStream = new MemoryStream();
			cc69bb88c75964e01f1ca2beabfaa629b.c30767ddca1f9c207888833aea5b5fc61(c6c5bdc1bc828868ac0bcfc17f26f6760.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), memoryStream, c66cdf8f359ad723e1140c64687224d7a.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c191cc919d4f42dd5a800d55c995e0acd = new BitmapImage();
			c9658151ce19e5e1d823834689c70b814.c30767ddca1f9c207888833aea5b5fc61(this.c191cc919d4f42dd5a800d55c995e0acd);
			c82e5ef82e3184dc0f741b8f40eeb8743.c30767ddca1f9c207888833aea5b5fc61(memoryStream, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21524), (SeekOrigin)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21528));
			c651e483dbb48d33f4c26fdea0fcdfb47.c30767ddca1f9c207888833aea5b5fc61(this.c191cc919d4f42dd5a800d55c995e0acd, memoryStream);
			cdf04d684c74310f6b407692022abceed.c30767ddca1f9c207888833aea5b5fc61(this.c191cc919d4f42dd5a800d55c995e0acd);
			memoryStream = new MemoryStream();
			cc69bb88c75964e01f1ca2beabfaa629b.c30767ddca1f9c207888833aea5b5fc61(c1fb3e78ed5d610ade02973d7beeeb764.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), memoryStream, c66cdf8f359ad723e1140c64687224d7a.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c8de530f3e6382d3b2f91780631d61919 = new BitmapImage();
			c9658151ce19e5e1d823834689c70b814.c30767ddca1f9c207888833aea5b5fc61(this.c8de530f3e6382d3b2f91780631d61919);
			c82e5ef82e3184dc0f741b8f40eeb8743.c30767ddca1f9c207888833aea5b5fc61(memoryStream, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21532), (SeekOrigin)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21536));
			c651e483dbb48d33f4c26fdea0fcdfb47.c30767ddca1f9c207888833aea5b5fc61(this.c8de530f3e6382d3b2f91780631d61919, memoryStream);
			cdf04d684c74310f6b407692022abceed.c30767ddca1f9c207888833aea5b5fc61(this.c8de530f3e6382d3b2f91780631d61919);
			this.cd2322d00bb2b1846e002c867c614232d = cbd965aa931171aaf2690f49f6b7621a1.cea69e7c4d1a729bd5783221de1566e79(c48c5d3b82cbcddd5f93d6bc807ea8573.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159876)));
			this.c0d8c68555854f07d401b833fcf35300e = cbd965aa931171aaf2690f49f6b7621a1.cea69e7c4d1a729bd5783221de1566e79(c48c5d3b82cbcddd5f93d6bc807ea8573.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159891)));
			this.c1d19582cffe423a1124756d0fe13de8d = cbd965aa931171aaf2690f49f6b7621a1.cea69e7c4d1a729bd5783221de1566e79(c48c5d3b82cbcddd5f93d6bc807ea8573.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159904)));
			this.c3c897f76a0f75ab801de66894978eafa = cbd965aa931171aaf2690f49f6b7621a1.cea69e7c4d1a729bd5783221de1566e79(c48c5d3b82cbcddd5f93d6bc807ea8573.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159925)));
			this.cda9121000da1204e1c6c6b5074e82397 = new c4abaf38aa559c219b0d9c3fcbe84127e();
			this.ca363176affcc7719c87ca60ddb5f6f34 = new ca0c9ecd43ccad62ae7ac89ac45149827();
			this.cde612ef6cd46010d5aa48e8da32c8dd1 = new System.Windows.Controls.ContextMenu();
			cb096d419b8adbd3184913ee8830e9592.c30767ddca1f9c207888833aea5b5fc61(this.cde612ef6cd46010d5aa48e8da32c8dd1, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21540) != 0);
			System.Windows.Controls.MenuItem menuItem = new System.Windows.Controls.MenuItem();
			cb964b2655eea326a94e3ec60d7b81ae9.c30767ddca1f9c207888833aea5b5fc61(menuItem, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159944));
			c61355e738d5265363246a1105fca70a2.c30767ddca1f9c207888833aea5b5fc61(menuItem, new RoutedEventHandler(this.Mi1_Click));
			System.Windows.Controls.MenuItem menuItem2 = new System.Windows.Controls.MenuItem();
			cb964b2655eea326a94e3ec60d7b81ae9.c30767ddca1f9c207888833aea5b5fc61(menuItem2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(50127));
			c61355e738d5265363246a1105fca70a2.c30767ddca1f9c207888833aea5b5fc61(menuItem2, new RoutedEventHandler(this.Mi2_Click));
			System.Windows.Controls.MenuItem menuItem3 = new System.Windows.Controls.MenuItem();
			cb964b2655eea326a94e3ec60d7b81ae9.c30767ddca1f9c207888833aea5b5fc61(menuItem3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159965));
			c61355e738d5265363246a1105fca70a2.c30767ddca1f9c207888833aea5b5fc61(menuItem3, new RoutedEventHandler(this.Mi4_Click));
			System.Windows.Controls.MenuItem menuItem4 = new System.Windows.Controls.MenuItem();
			cb964b2655eea326a94e3ec60d7b81ae9.c30767ddca1f9c207888833aea5b5fc61(menuItem4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159992));
			c61355e738d5265363246a1105fca70a2.c30767ddca1f9c207888833aea5b5fc61(menuItem4, new RoutedEventHandler(this.Mi6_Click));
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.cde612ef6cd46010d5aa48e8da32c8dd1), menuItem3);
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.cde612ef6cd46010d5aa48e8da32c8dd1), menuItem4);
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.cde612ef6cd46010d5aa48e8da32c8dd1), new Separator());
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.cde612ef6cd46010d5aa48e8da32c8dd1), menuItem);
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.cde612ef6cd46010d5aa48e8da32c8dd1), menuItem2);
			this.cf3f1975cf13c851b2e7343e0b5d97e7d = new Dictionary<string, c8bcd65ef9c4ef9760bfa9987e3b9d9f7>();
			c54a886fa551a7b25c7600d25831f0949.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, new System.Windows.DragEventHandler(this.AccList_DragOver));
			c1d9dfbcad43977d2402697c743bf5c8f.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, new System.Windows.DragEventHandler(this.AccList_Drop));
			c6a1a59e11663be36edb3fcd92d674a35.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, new System.Windows.Input.MouseEventHandler(this.AccList_MouseMove));
			cde8934924ab7f6cf7fb6956892e95cfd.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, new MouseButtonEventHandler(this.AccList_MouseDown));
			c33bc772e4c0878b7764bfe9da5b21d42.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, new WorldTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153707)));
			c33bc772e4c0878b7764bfe9da5b21d42.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, new WorldTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153667)));
			c33bc772e4c0878b7764bfe9da5b21d42.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, new WorldTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153680)));
			c33bc772e4c0878b7764bfe9da5b21d42.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, new WorldTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(22)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(ceaa62c091f06923c8723464b639899db.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21544))), new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(22), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21548)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160017), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21552)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160028), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21556)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160043), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21560)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160060), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21564)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160071), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21568)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160084), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21572)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160099), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21576)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160110), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21580)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160123), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21584)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160134), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21588)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160145), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21592)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160164), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21596)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160181), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21600)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160198), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21604)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160213), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21608)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160224), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21612)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160237), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21616)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160252), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21620)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160271), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21624)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160288), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21628)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160303), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21632)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160318), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21636)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160331), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21640)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160340), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21644)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160355), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21648)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160372), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21652)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160383), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21656)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160396), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21660)));
			c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, new ServerTreeViewInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160409), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21664)));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21668); i < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21676))
			{
				c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(ceaa62c091f06923c8723464b639899db.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21672))), c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, i));
			}
			while (true)
			{
				switch (3)
				{
				case 0:
					continue;
				}
				break;
			}
			if (!true)
			{
				RuntimeMethodHandle arg_B28_0 = methodof(cbf4111912aed594f2b4372828dd95aa3..ctor()).MethodHandle;
			}
			for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21680); j < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21688))
			{
				c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(ceaa62c091f06923c8723464b639899db.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21684))), c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, j));
			}
			while (true)
			{
				switch (4)
				{
				case 0:
					continue;
				}
				break;
			}
			for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21692); k < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21700))
			{
				c912dc525b673348e0112356a5fb94e35.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(ceaa62c091f06923c8723464b639899db.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21696))), c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, k));
			}
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			cc79c33ca5e15f651f8c3f5283fddae64.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, this.c4fc5dab2c31ad3f0faa92b746c49837e);
			c318fb189283ebe3b3d5d5558814fe2e3.c30767ddca1f9c207888833aea5b5fc61(this.c88aaa8af9bfe41a2300eab3d3ccb64f9, new bool?(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c88aaa8af9bfe41a2300eab3d3ccb64f9()));
			c318fb189283ebe3b3d5d5558814fe2e3.c30767ddca1f9c207888833aea5b5fc61(this.c84d133f6e01cc85098ac63431589cbe3, new bool?(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c84d133f6e01cc85098ac63431589cbe3()));
			c318fb189283ebe3b3d5d5558814fe2e3.c30767ddca1f9c207888833aea5b5fc61(this.cbbc8bbcc1bf558ff8a0e06abd62f13d7, new bool?(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_cbbc8bbcc1bf558ff8a0e06abd62f13d7()));
			this.cac383f9c4c18ddf9fcd22b48958556c9();
			DispatcherTimer dispatcherTimer = new DispatcherTimer();
			ceb184b7ba0e1852b4dd2f575a835a7d2.c30767ddca1f9c207888833aea5b5fc61(dispatcherTimer, new EventHandler(this.timerTick));
			c22aa437df0756bf298d0f3ce68fa90b9.c30767ddca1f9c207888833aea5b5fc61(dispatcherTimer, cca46d0327571b189c947bb29aa3c5d0c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(21704)));
			ca204cba1556aeb9c107fa4182cf74aae.c30767ddca1f9c207888833aea5b5fc61(dispatcherTimer);
			cc79c33ca5e15f651f8c3f5283fddae64.c30767ddca1f9c207888833aea5b5fc61(this.cfc72e1593fda015b04d1c33a1c5ae79d, c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			c047ca99169d8e43644c96975f2bb0a53.c30767ddca1f9c207888833aea5b5fc61(this.cfc72e1593fda015b04d1c33a1c5ae79d, UIElement.MouseDownEvent, new MouseButtonEventHandler(this.pluginsList_PreviewMouseDown), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21712) != 0);
			c047ca99169d8e43644c96975f2bb0a53.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, UIElement.MouseDownEvent, new MouseButtonEventHandler(this.accList_PreviewMouseDown), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21716) != 0);
			c047ca99169d8e43644c96975f2bb0a53.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68, UIElement.MouseDownEvent, new MouseButtonEventHandler(this.schedulerInfo_PreviewMouseDown), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21720) != 0);
			c12b468f10135a69c459dfa888d6f1183.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, this);
			this.cbd31021d0be605c2efd37e991a4c8e0d();
			c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Task(new Action(this.c6866c3f94257a47c85026e375e297438)));
			c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Task(new Action(this.c1a24697e9882c277735bd6b5e986e48b)));
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00055F44 File Offset: 0x00054144
		static cbf4111912aed594f2b4372828dd95aa3()
		{
			// Note: this type is marked as 'beforefieldinit'.
			DateTime dateTime = ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			cbf4111912aed594f2b4372828dd95aa3.random = c23a147e99f4e2aa43079a0a582fcb55b.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)cbe160155a0bbac79148ab3a24f3f70db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime));
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00055F70 File Offset: 0x00054170
		public ObservableCollection<SchedulerInfo> SchedulerInfos
		{
			get
			{
				if (this.c2e1956eefc5b4edaa1fa8515bd955ae7 == null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_1A_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.get_SchedulerInfos()).MethodHandle;
					}
					this.c2e1956eefc5b4edaa1fa8515bd955ae7 = cc2b127d42a823f46b99ee273db129359.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				return this.c2e1956eefc5b4edaa1fa8515bd955ae7;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00055FAC File Offset: 0x000541AC
		public ObservableCollection<PluginInfoDataGrid> Plugins
		{
			get
			{
				if (this.c854bacc98918774f7cd95449627b0cbf == null)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_1A_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.get_Plugins()).MethodHandle;
					}
					this.c854bacc98918774f7cd95449627b0cbf = c0e35bda5b1d8c8d1416ab9cda8f8bc2e.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				return this.c854bacc98918774f7cd95449627b0cbf;
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00055FE8 File Offset: 0x000541E8
		public void c5e187df5cedd5db95e3b28da96f32763()
		{
			IEnumerable<AccTreeViewInfo> arg_37_0 = this.cd559d791bccc45933a81e7e47e42fd1b;
			if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate2 == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_20_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c5e187df5cedd5db95e3b28da96f32763()).MethodHandle;
				}
				cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate2 = new Func<AccTreeViewInfo, int>(cbf4111912aed594f2b4372828dd95aa3.c714501f6a77d2e2487da34a8d4c4d5c6);
			}
			this.cd559d791bccc45933a81e7e47e42fd1b = c79fb0b96c844b1a9a0d37e74402c06d7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(arg_37_0.OrderByDescending(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate2));
			IEnumerator<WorldTreeViewInfo> enumerator = c64aaef4a72b1cca6cf3b8e689c30656c.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e);
			try
			{
				while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
				{
					WorldTreeViewInfo worldTreeViewInfo = c6cb3068dd1dba97b102455710cf6a79f.c30767ddca1f9c207888833aea5b5fc61(enumerator);
					IEnumerator<ServerTreeViewInfo> enumerator2 = c266116c92138d153032ef71f5e63e4fc.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(worldTreeViewInfo));
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator2))
						{
							ServerTreeViewInfo serverTreeViewInfo = c6ab76f0df3a33e553b2cfe7c47b9f13b.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
							object arg_BF_0 = serverTreeViewInfo;
							IEnumerable<AccTreeViewInfo> expr_88 = c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo);
							if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate3 == null)
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate3 = new Func<AccTreeViewInfo, int>(cbf4111912aed594f2b4372828dd95aa3.c37e678a328db150c3510d930065b8772);
							}
							c23f147665e3d2c349eebb798e9d05381.c30767ddca1f9c207888833aea5b5fc61(arg_BF_0, c79fb0b96c844b1a9a0d37e74402c06d7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_88.OrderByDescending(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate3)));
						}
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
						}
					}
				}
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
				}
			}
			cc79c33ca5e15f651f8c3f5283fddae64.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, c48c2411baaca6a3dd7066e4f1a8b2e22.c8a754f5f2ca4adde825691a9c31a0e83);
			if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c88aaa8af9bfe41a2300eab3d3ccb64f9())
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				cc79c33ca5e15f651f8c3f5283fddae64.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, this.cd559d791bccc45933a81e7e47e42fd1b);
				return;
			}
			cc79c33ca5e15f651f8c3f5283fddae64.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, this.c4fc5dab2c31ad3f0faa92b746c49837e);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00056178 File Offset: 0x00054378
		public void ce2faeeef9497f63054b3dba88165c55c()
		{
			List<cd4d5a5684d153eefc4ebe1d89a85e677> list = this.ca363176affcc7719c87ca60ddb5f6f34.cc4580102445ef1f184140ef81988e335();
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18096); i < c1716b2c507821b26fb0506974591ccfd.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18152))
			{
				AccTreeViewInfo accTreeViewInfo = c94516ceba74807efe1af51937197cd7e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c52a92df122357a5cd3b1d8caa10b3098.c30767ddca1f9c207888833aea5b5fc61(list, i));
				cf2312b0c4a53576fb482120f0ace61d7.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo, this.cfb755cb93a73f30822ce601a125376d8);
				int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18100);
				c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c52a92df122357a5cd3b1d8caa10b3098.c30767ddca1f9c207888833aea5b5fc61(list, i).cdfd15fd9767ca3c899334e0591fc3b13, ref num);
				bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18104) != 0;
				if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c52a92df122357a5cd3b1d8caa10b3098.c30767ddca1f9c207888833aea5b5fc61(list, i).c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153667)))
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_A2_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ce2faeeef9497f63054b3dba88165c55c()).MethodHandle;
					}
					for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18108); j < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18116))
					{
						if ((int)c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, j).cb5905b594e11dea2f73932df05981674 == num)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, j)), accTreeViewInfo);
							flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18112) != 0);
							goto IL_29C;
						}
					}
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				else if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c52a92df122357a5cd3b1d8caa10b3098.c30767ddca1f9c207888833aea5b5fc61(list, i).c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153680)))
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18120); k < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18128))
					{
						if ((int)c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, k).cb5905b594e11dea2f73932df05981674 == num)
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, k)), accTreeViewInfo);
							flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18124) != 0);
							goto IL_29C;
						}
					}
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				else if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c52a92df122357a5cd3b1d8caa10b3098.c30767ddca1f9c207888833aea5b5fc61(list, i).c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153707)))
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18132); l < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18140))
					{
						if ((int)c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, l).cb5905b594e11dea2f73932df05981674 == num)
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, l)), accTreeViewInfo);
							flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18136) != 0);
							goto IL_29C;
						}
					}
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				IL_29C:
				if (!flag)
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(ceaa62c091f06923c8723464b639899db.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18144))), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18148))), accTreeViewInfo);
				}
				cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b, accTreeViewInfo);
			}
			while (true)
			{
				switch (3)
				{
				case 0:
					continue;
				}
				break;
			}
			this.c5e187df5cedd5db95e3b28da96f32763();
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000564A4 File Offset: 0x000546A4
		public void cbd31021d0be605c2efd37e991a4c8e0d()
		{
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c8df21b00eff0ed569413a87a911e5013, AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(110969)));
			c82ecc83577068b4801cb9db5653c2f36.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86));
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(115338)));
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(115449)));
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(115542)));
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(115657)));
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(115762)));
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(115861)));
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(115945)));
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(116031)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.ccc0636f4a644fc4f9f06441bbe0c2846, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(48338)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c24b1965c9896834d4187c19ba7093972, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(101528)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.ce5ce055c72ecedf2962ba7fd9b5e7f5f, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(37715)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.cc22bb4f2cff81a8f70e301227c30d3c4, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(37622)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c0e369422f408b2e020172466b4f8736c, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(97221)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c154e386a06a48e617374cb3084b15d16, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(50353)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.cd9d6c8eccb641592989df004f1e1c45f, AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(97394)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c386b1b83ce21956322c985b3cb290769, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(97370)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.cc79f597a2913f924f2fe28dda0a22997, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(97328)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c0a14c009d8a27ed957e23cfcb83bda29, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(37715)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c94d2964e7b52ca96b96f6963a0b4debe, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(37622)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c0b0afb159eaf61457df227310912e74e, AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(109969)));
			c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c661edb793c0ae9dd33ed1849ba92660b, AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(110183)));
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000568D4 File Offset: 0x00054AD4
		private void accList_PreviewMouseDown(object sender, MouseButtonEventArgs e)
		{
			if (ccc13156fb31d58afc6afe280c74a5508.c30767ddca1f9c207888833aea5b5fc61(e) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18156))
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_26_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.accList_PreviewMouseDown(object, MouseButtonEventArgs)).MethodHandle;
				}
				return;
			}
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 != null)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				IntPtr intPtr = ce4372152aa9f558706ecbad44e457566.c30767ddca1f9c207888833aea5b5fc61(c591b3807e3508f06381b8edb380d1130.c0cf59c3e67a46fd4edb3040c5ab0bbfb(accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.cbcddc98bc608c531a1e08a77c2239014));
				cec4dc845e772c3e699a057c528837cac.c79b099664bdd394100d439c28a842382(intPtr);
				cec4dc845e772c3e699a057c528837cac.c4495727acb05dc03d637e80f93529881(intPtr, (cec4dc845e772c3e699a057c528837cac.cca9309395208b743ce90568e6c4e72e8)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18160));
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000569A4 File Offset: 0x00054BA4
		private void cc5bf0d741f11b1f66dc940572015c1e2(c8bcd65ef9c4ef9760bfa9987e3b9d9f7 c7a0383e67c28fa211b6e3f641eebf67a)
		{
			cbf4111912aed594f2b4372828dd95aa3.c419c1226a9df336fca651c1f31ce5861 c419c1226a9df336fca651c1f31ce = new cbf4111912aed594f2b4372828dd95aa3.c419c1226a9df336fca651c1f31ce5861();
			c419c1226a9df336fca651c1f31ce.c7a0383e67c28fa211b6e3f641eebf67a = c7a0383e67c28fa211b6e3f641eebf67a;
			c419c1226a9df336fca651c1f31ce.cb6ea3d298d68be569f5410cc290458d5 = this;
			Action action = new Action(c419c1226a9df336fca651c1f31ce.ce9f32637bede6bf4a48154720b3f2692);
			if (!c6f7ee37dd29567ef10442c1148614a20.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_44_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.cc5bf0d741f11b1f66dc940572015c1e2(c8bcd65ef9c4ef9760bfa9987e3b9d9f7)).MethodHandle;
				}
				c945f8c0caac6afd3e423205e93db941b.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), action);
				return;
			}
			cfcdf5ac55f9adba1a267019243e23146.c30767ddca1f9c207888833aea5b5fc61(action);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00056A0C File Offset: 0x00054C0C
		private void cd08b94b28e3d9b4476009e81147dce41(string c48300d096770fcd924fa7ebade9fd6a)
		{
			cbf4111912aed594f2b4372828dd95aa3.ca7d9f6c15dad312217b0b35d021f7352 ca7d9f6c15dad312217b0b35d021f = new cbf4111912aed594f2b4372828dd95aa3.ca7d9f6c15dad312217b0b35d021f7352();
			ca7d9f6c15dad312217b0b35d021f.c48300d096770fcd924fa7ebade9fd6a3 = c48300d096770fcd924fa7ebade9fd6a;
			ca7d9f6c15dad312217b0b35d021f.cb6ea3d298d68be569f5410cc290458d5 = this;
			Action action = new Action(ca7d9f6c15dad312217b0b35d021f.c1bd5f84fed3cdb5a0214f6c03ec0f931);
			if (!c6f7ee37dd29567ef10442c1148614a20.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_44_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.cd08b94b28e3d9b4476009e81147dce41(string)).MethodHandle;
				}
				c945f8c0caac6afd3e423205e93db941b.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), action);
				return;
			}
			cfcdf5ac55f9adba1a267019243e23146.c30767ddca1f9c207888833aea5b5fc61(action);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00056A74 File Offset: 0x00054C74
		private void tab_onRemove(object sender, RoutedEventArgs e)
		{
			try
			{
				if (sender == null)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_15_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.tab_onRemove(object, RoutedEventArgs)).MethodHandle;
					}
				}
				else
				{
					string text = c5bdadb216ff81200f68025e2298d040e.c9963fcf210a214a3206d6500f3b9397b(c1a9b7b7260cfaa86577c28e97f7da39e.c30767ddca1f9c207888833aea5b5fc61(c57b0a3fd67ce8518bb86291e5f00392a.cea69e7c4d1a729bd5783221de1566e79(sender)));
					cfdc3ed99c299fb320b4e23ac7ba43cee.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c137007dcdad6a7942fc1d5e11b9a4faa), sender);
					if (c6bdbf9189dce82b2c721765817912595.c30767ddca1f9c207888833aea5b5fc61(this.cf3f1975cf13c851b2e7343e0b5d97e7d, text))
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						c657733adf60561a6d605eb5fde7e3fbc.c30767ddca1f9c207888833aea5b5fc61(this.cf3f1975cf13c851b2e7343e0b5d97e7d, text).c773f838d678cd0af3ed65ba3a8517ed6 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18164) != 0);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00056B10 File Offset: 0x00054D10
		private void tb_TextChanged(object sender, TextChangedEventArgs e)
		{
			cd43d93d3363170b555139e4bf1dfb034.c30767ddca1f9c207888833aea5b5fc61(cd509ec1cec8b1e4c7436a01530244223.cea69e7c4d1a729bd5783221de1566e79(sender));
			ce1c4e648f22454a9682fc21bb8e39112.c30767ddca1f9c207888833aea5b5fc61(cd509ec1cec8b1e4c7436a01530244223.cea69e7c4d1a729bd5783221de1566e79(sender));
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00056B38 File Offset: 0x00054D38
		internal void cdec08c245806a34f01c9706eac9a8a1e(string text = "[Main]")
		{
			try
			{
				cbf4111912aed594f2b4372828dd95aa3.c17239c9cccf3493ba3ee09147f6ecc4a c17239c9cccf3493ba3ee09147f6ecc4a = new cbf4111912aed594f2b4372828dd95aa3.c17239c9cccf3493ba3ee09147f6ecc4a();
				if (!c6bdbf9189dce82b2c721765817912595.c30767ddca1f9c207888833aea5b5fc61(this.cf3f1975cf13c851b2e7343e0b5d97e7d, text))
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_28_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.cdec08c245806a34f01c9706eac9a8a1e(string)).MethodHandle;
					}
					this.cd08b94b28e3d9b4476009e81147dce41(text);
				}
				c17239c9cccf3493ba3ee09147f6ecc4a.c3b3af64991b29c36fd4ca79eb06ec59b = c657733adf60561a6d605eb5fde7e3fbc.c30767ddca1f9c207888833aea5b5fc61(this.cf3f1975cf13c851b2e7343e0b5d97e7d, text);
				Action action = new Action(c17239c9cccf3493ba3ee09147f6ecc4a.c28ccbcf9559ddfb0aa343124b0e6ef45);
				if (!c6f7ee37dd29567ef10442c1148614a20.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					c945f8c0caac6afd3e423205e93db941b.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), action);
				}
				else
				{
					cfcdf5ac55f9adba1a267019243e23146.c30767ddca1f9c207888833aea5b5fc61(action);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00056BEC File Offset: 0x00054DEC
		internal void c6c3244fa3c4264235746291c63a5ef7f(System.Drawing.Color c92db0354aea42f5493f4b7110ed18cf, string text = "[Main]")
		{
			try
			{
				if (!c6bdbf9189dce82b2c721765817912595.c30767ddca1f9c207888833aea5b5fc61(this.cf3f1975cf13c851b2e7343e0b5d97e7d, text))
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_22_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c6c3244fa3c4264235746291c63a5ef7f(System.Drawing.Color, string)).MethodHandle;
					}
					this.cd08b94b28e3d9b4476009e81147dce41(text);
				}
				c8bcd65ef9c4ef9760bfa9987e3b9d9f7 c8bcd65ef9c4ef9760bfa9987e3b9d9f = c657733adf60561a6d605eb5fde7e3fbc.c30767ddca1f9c207888833aea5b5fc61(this.cf3f1975cf13c851b2e7343e0b5d97e7d, text);
				c8bcd65ef9c4ef9760bfa9987e3b9d9f.c92db0354aea42f5493f4b7110ed18cf1 = c92db0354aea42f5493f4b7110ed18cf;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00056C5C File Offset: 0x00054E5C
		internal void cca63eea59ff63f5ed12c992461dedacf(System.Drawing.Color cd4e00ad3d769e8634db871a069991a, string text = "[Main]")
		{
			cbf4111912aed594f2b4372828dd95aa3.cdbdbbb0fa695f1526f03e8723de7f431 cdbdbbb0fa695f1526f03e8723de7f = new cbf4111912aed594f2b4372828dd95aa3.cdbdbbb0fa695f1526f03e8723de7f431();
			cdbdbbb0fa695f1526f03e8723de7f.cd4e00ad3d769e8634db871a069991a75 = cd4e00ad3d769e8634db871a069991a;
			try
			{
				cbf4111912aed594f2b4372828dd95aa3.c42b74606b23c194db966233814bf1d35 c42b74606b23c194db966233814bf1d = new cbf4111912aed594f2b4372828dd95aa3.c42b74606b23c194db966233814bf1d35();
				c42b74606b23c194db966233814bf1d.c75c88b595486185bda84f394888b039a = cdbdbbb0fa695f1526f03e8723de7f;
				if (!c6bdbf9189dce82b2c721765817912595.c30767ddca1f9c207888833aea5b5fc61(this.cf3f1975cf13c851b2e7343e0b5d97e7d, text))
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_3C_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.cca63eea59ff63f5ed12c992461dedacf(System.Drawing.Color, string)).MethodHandle;
					}
					this.cd08b94b28e3d9b4476009e81147dce41(text);
				}
				c42b74606b23c194db966233814bf1d.c3b3af64991b29c36fd4ca79eb06ec59b = c657733adf60561a6d605eb5fde7e3fbc.c30767ddca1f9c207888833aea5b5fc61(this.cf3f1975cf13c851b2e7343e0b5d97e7d, text);
				Action action = new Action(c42b74606b23c194db966233814bf1d.c7c2f5c3ebb34b694e3fac50d650c9b71);
				if (!c6f7ee37dd29567ef10442c1148614a20.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					c945f8c0caac6afd3e423205e93db941b.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), action);
				}
				else
				{
					cfcdf5ac55f9adba1a267019243e23146.c30767ddca1f9c207888833aea5b5fc61(action);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00056D24 File Offset: 0x00054F24
		internal void c8299fa31317d146976f1ea9cd623369b(string c195a54fbdf960ff8ef1ef331acb79a1a, System.Drawing.Color cd4e00ad3d769e8634db871a069991a, bool c4bad6262985be3f53a16074916f6fcec = true, string text = "[Main]")
		{
			cbf4111912aed594f2b4372828dd95aa3.ca6bbc4dff6abf9961b798d2c33f0f5dc ca6bbc4dff6abf9961b798d2c33f0f5dc = new cbf4111912aed594f2b4372828dd95aa3.ca6bbc4dff6abf9961b798d2c33f0f5dc();
			ca6bbc4dff6abf9961b798d2c33f0f5dc.c195a54fbdf960ff8ef1ef331acb79a1a = c195a54fbdf960ff8ef1ef331acb79a1a;
			ca6bbc4dff6abf9961b798d2c33f0f5dc.cd4e00ad3d769e8634db871a069991a75 = cd4e00ad3d769e8634db871a069991a;
			ca6bbc4dff6abf9961b798d2c33f0f5dc.c4bad6262985be3f53a16074916f6fcec = c4bad6262985be3f53a16074916f6fcec;
			try
			{
				cbf4111912aed594f2b4372828dd95aa3.cc70c0687bdf847e6bb523ea92e8d5934 cc70c0687bdf847e6bb523ea92e8d = new cbf4111912aed594f2b4372828dd95aa3.cc70c0687bdf847e6bb523ea92e8d5934();
				cc70c0687bdf847e6bb523ea92e8d.c2c71f2d7a522415a7cd1c9439cda17b1 = ca6bbc4dff6abf9961b798d2c33f0f5dc;
				if (!c6bdbf9189dce82b2c721765817912595.c30767ddca1f9c207888833aea5b5fc61(this.cf3f1975cf13c851b2e7343e0b5d97e7d, text))
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_4B_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c8299fa31317d146976f1ea9cd623369b(string, System.Drawing.Color, bool, string)).MethodHandle;
					}
					this.cd08b94b28e3d9b4476009e81147dce41(text);
				}
				cc70c0687bdf847e6bb523ea92e8d.c3b3af64991b29c36fd4ca79eb06ec59b = c657733adf60561a6d605eb5fde7e3fbc.c30767ddca1f9c207888833aea5b5fc61(this.cf3f1975cf13c851b2e7343e0b5d97e7d, text);
				Action action = new Action(cc70c0687bdf847e6bb523ea92e8d.c9db941f8da6c1beb6f50c283f537bcc6);
				if (!c6f7ee37dd29567ef10442c1148614a20.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					c945f8c0caac6afd3e423205e93db941b.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), action);
				}
				else
				{
					cfcdf5ac55f9adba1a267019243e23146.c30767ddca1f9c207888833aea5b5fc61(action);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00056DFC File Offset: 0x00054FFC
		internal void c8299fa31317d146976f1ea9cd623369b(string text, string text2 = "[Main]")
		{
			try
			{
				if (!c6bdbf9189dce82b2c721765817912595.c30767ddca1f9c207888833aea5b5fc61(this.cf3f1975cf13c851b2e7343e0b5d97e7d, text2))
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_22_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c8299fa31317d146976f1ea9cd623369b(string, string)).MethodHandle;
					}
					this.cd08b94b28e3d9b4476009e81147dce41(text2);
				}
				c8bcd65ef9c4ef9760bfa9987e3b9d9f7 c8bcd65ef9c4ef9760bfa9987e3b9d9f = c657733adf60561a6d605eb5fde7e3fbc.c30767ddca1f9c207888833aea5b5fc61(this.cf3f1975cf13c851b2e7343e0b5d97e7d, text2);
				if (!c8bcd65ef9c4ef9760bfa9987e3b9d9f.c773f838d678cd0af3ed65ba3a8517ed6)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					this.cc5bf0d741f11b1f66dc940572015c1e2(c8bcd65ef9c4ef9760bfa9987e3b9d9f);
				}
				List<cbf4111912aed594f2b4372828dd95aa3.c8a52867e86c70d29f644cd95db0728a4> list = c59212b0588bbaf9da75f12a9829c5157.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153720)) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18168))
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					cc04e1140ac8cb41e5e5df1570c434a9b.c30767ddca1f9c207888833aea5b5fc61(list, new cbf4111912aed594f2b4372828dd95aa3.c8a52867e86c70d29f644cd95db0728a4
					{
						c279d72299fc1a7f545ad43126ff18dbe = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18172), cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153720))),
						cd4e00ad3d769e8634db871a069991a75 = c8bcd65ef9c4ef9760bfa9987e3b9d9f.c92db0354aea42f5493f4b7110ed18cf1
					});
					text = cdea27b7a0e0cc37081ac21c078bcf552.c30767ddca1f9c207888833aea5b5fc61(text, cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153720)));
				}
				while (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153720)) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18204))
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153737)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18208))
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							goto IL_24F;
						}
					}
					else
					{
						int num = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152310));
						int num2 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153737));
						if (num == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18176))
						{
							break;
						}
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						if (num2 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18180))
						{
							break;
						}
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.c8a52867e86c70d29f644cd95db0728a4 c8a52867e86c70d29f644cd95db0728a = default(cbf4111912aed594f2b4372828dd95aa3.c8a52867e86c70d29f644cd95db0728a4);
						string text3 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18184), num - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18188));
						string c279d72299fc1a7f545ad43126ff18dbe = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, num + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18192), num2 - num - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18196));
						c8a52867e86c70d29f644cd95db0728a.c279d72299fc1a7f545ad43126ff18dbe = c279d72299fc1a7f545ad43126ff18dbe;
						c8a52867e86c70d29f644cd95db0728a.cd4e00ad3d769e8634db871a069991a75 = c20089aee343859621a422147c9e74704.cc6a9c540a2ed5763275f32ba91c9e97b(c2d80901c7e2d859fd1e7f8071d4a2631.c30767ddca1f9c207888833aea5b5fc61(c80979d83fcf69a0e43d3e59e575b6650.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdbe616fedcf45619c882ac5f9529de57.cbac80c0356856482e0a93eed1c1fdf4f())), text3));
						text = cdea27b7a0e0cc37081ac21c078bcf552.c30767ddca1f9c207888833aea5b5fc61(text, num2 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18200));
						cc04e1140ac8cb41e5e5df1570c434a9b.c30767ddca1f9c207888833aea5b5fc61(list, c8a52867e86c70d29f644cd95db0728a);
					}
				}
				IL_24F:
				if (c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18212))
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					cc04e1140ac8cb41e5e5df1570c434a9b.c30767ddca1f9c207888833aea5b5fc61(list, new cbf4111912aed594f2b4372828dd95aa3.c8a52867e86c70d29f644cd95db0728a4
					{
						c279d72299fc1a7f545ad43126ff18dbe = text,
						cd4e00ad3d769e8634db871a069991a75 = c8bcd65ef9c4ef9760bfa9987e3b9d9f.c92db0354aea42f5493f4b7110ed18cf1
					});
				}
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18216); i < cebc578020a4338a645eabb08feb382b2.c30767ddca1f9c207888833aea5b5fc61(list) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18228); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18224))
				{
					this.c8299fa31317d146976f1ea9cd623369b(ca8359bf5539cf89cd04cc5c5f439f2dd.c30767ddca1f9c207888833aea5b5fc61(list, i).c279d72299fc1a7f545ad43126ff18dbe, ca8359bf5539cf89cd04cc5c5f439f2dd.c30767ddca1f9c207888833aea5b5fc61(list, i).cd4e00ad3d769e8634db871a069991a75, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18220) != 0, text2);
				}
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (cebc578020a4338a645eabb08feb382b2.c30767ddca1f9c207888833aea5b5fc61(list) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18232))
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					this.c8299fa31317d146976f1ea9cd623369b(ca8359bf5539cf89cd04cc5c5f439f2dd.c30767ddca1f9c207888833aea5b5fc61(list, cebc578020a4338a645eabb08feb382b2.c30767ddca1f9c207888833aea5b5fc61(list) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18236)).c279d72299fc1a7f545ad43126ff18dbe, ca8359bf5539cf89cd04cc5c5f439f2dd.c30767ddca1f9c207888833aea5b5fc61(list, cebc578020a4338a645eabb08feb382b2.c30767ddca1f9c207888833aea5b5fc61(list) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18240)).cd4e00ad3d769e8634db871a069991a75, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18244) != 0, text2);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000571A8 File Offset: 0x000553A8
		private void StartToolStripButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				cbf4111912aed594f2b4372828dd95aa3.c4b5a63e5fdca11ac13bd0e78dd642df7 c4b5a63e5fdca11ac13bd0e78dd642df = new cbf4111912aed594f2b4372828dd95aa3.c4b5a63e5fdca11ac13bd0e78dd642df7();
				c4b5a63e5fdca11ac13bd0e78dd642df.cb6ea3d298d68be569f5410cc290458d5 = this;
				c4b5a63e5fdca11ac13bd0e78dd642df.c97bb0419a7a851c991e9e986b8e0f5c1 = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
				c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c50727e34948ef9b15203539df949de95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Action(c4b5a63e5fdca11ac13bd0e78dd642df.c512cfa55766576c33e87353867872bf6)));
			}
			catch
			{
				this.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(97954)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00057234 File Offset: 0x00055434
		private void StopToolStripButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
				if (accTreeViewInfo != null)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_2A_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.StopToolStripButton_Click(object, RoutedEventArgs)).MethodHandle;
					}
					if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 != null)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.c5e071fc90b6534e9e9071f415f5b7deb();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x000572A0 File Offset: 0x000554A0
		private void NewToolStripButton_Click(object sender, RoutedEventArgs e)
		{
			cc2d227db33e2eee9ffd1ed98f2bf178e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, null, ca7e2f3416120249715e23fda9b04344c.c8a754f5f2ca4adde825691a9c31a0e83);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x000572BC File Offset: 0x000554BC
		private void DeleteToolStripButton_Click(object sender, RoutedEventArgs e)
		{
			c1b08e595e545387241648da83f4818a4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, null, ca7e2f3416120249715e23fda9b04344c.c8a754f5f2ca4adde825691a9c31a0e83);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000572D8 File Offset: 0x000554D8
		private void ExportToExcelButton_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = c75b92b4605d548d1a7bc3d92c66ba6d6.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			caf3f6fde759bf8588af13067b1537ec2.c30767ddca1f9c207888833aea5b5fc61(saveFileDialog, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153754));
			c4208d1ead8aba9af768229617f3d1a31.c30767ddca1f9c207888833aea5b5fc61(saveFileDialog, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18248));
			c61521f76d769e0abddc65d6e14f31ad7.c30767ddca1f9c207888833aea5b5fc61(saveFileDialog, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18252) != 0);
			if (cfd96c11a4b731b6425b00551c0f24764.c30767ddca1f9c207888833aea5b5fc61(saveFileDialog) == (DialogResult)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18256))
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_63_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ExportToExcelButton_Click(object, RoutedEventArgs)).MethodHandle;
				}
				string text = c937b26b91edf22459746372744691625.c30767ddca1f9c207888833aea5b5fc61(saveFileDialog);
				if (cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text))
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					this.c8299fa31317d146976f1ea9cd623369b(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153841), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				}
				if (!c49b76edf1940c188fa37efd6d026df37.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153892)))
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					text = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153892));
				}
				if (this.ca363176affcc7719c87ca60ddb5f6f34.c3d564d3f301a1b63e2017c4b4f4cc6dc(text))
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					this.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153901), text), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				}
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000573FC File Offset: 0x000555FC
		private bool c5b4d4792b2ce59e0f6ac76386755e5a8(string text)
		{
			try
			{
				TextFieldParser textFieldParser = cf0574f4c1fa880959b236ed6820d249e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text);
				c762d32ade7b60f1e69d3c43501c14fba.c30767ddca1f9c207888833aea5b5fc61(textFieldParser, (FieldType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18260));
				object arg_48_0 = textFieldParser;
				string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18264));
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18268)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(122007);
				c95842c98c68d70e4ffbab62d5ed52ce8.c30767ddca1f9c207888833aea5b5fc61(arg_48_0, array);
				int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18272);
				bool result;
				while (!c49a2cb85de35633b798895b5851eeef9.c30767ddca1f9c207888833aea5b5fc61(textFieldParser))
				{
					List<string> list = c730f27d5c8997ea3da3b8bf80c859424.c30767ddca1f9c207888833aea5b5fc61(textFieldParser).ToList<string>();
					if (c917285c46e176f472f1c2753bdd49aab.c30767ddca1f9c207888833aea5b5fc61(list) < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18276))
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_93_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c5b4d4792b2ce59e0f6ac76386755e5a8(string)).MethodHandle;
						}
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18280) != 0);
						return result;
					}
					string text2 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18284));
					string text3 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18288));
					string text4 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18292));
					string text5 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18296));
					string text6 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18300));
					string text7 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18304));
					string text8 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18308));
					string text9 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18312));
					string text10 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18316));
					string text11 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18320));
					num += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18324);
					if (num != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18328))
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2))
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
							if (!cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text3))
							{
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									break;
								}
								if (!cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text4))
								{
									while (true)
									{
										switch (5)
										{
										case 0:
											continue;
										}
										break;
									}
									if (!cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text5))
									{
										while (true)
										{
											switch (6)
											{
											case 0:
												continue;
											}
											break;
										}
										if (!cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text6))
										{
											while (true)
											{
												switch (2)
												{
												case 0:
													continue;
												}
												break;
											}
											if (!cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text7))
											{
												while (true)
												{
													switch (6)
													{
													case 0:
														continue;
													}
													break;
												}
												if (!this.ca363176affcc7719c87ca60ddb5f6f34.c65bec2003555d77974bf8ce4f35d0e8c(text3, text2))
												{
													while (true)
													{
														switch (5)
														{
														case 0:
															continue;
														}
														break;
													}
													Func<ServerTreeViewInfo, bool> func = c7587aaefdaf8775287a710bc42882968.c8a754f5f2ca4adde825691a9c31a0e83;
													Func<ServerTreeViewInfo, bool> func2 = c7587aaefdaf8775287a710bc42882968.c8a754f5f2ca4adde825691a9c31a0e83;
													Func<ServerTreeViewInfo, bool> func3 = c7587aaefdaf8775287a710bc42882968.c8a754f5f2ca4adde825691a9c31a0e83;
													cbf4111912aed594f2b4372828dd95aa3.cd817f0078f4e100ef0941cb6d95929ac cd817f0078f4e100ef0941cb6d95929ac = new cbf4111912aed594f2b4372828dd95aa3.cd817f0078f4e100ef0941cb6d95929ac();
													DateTime dateTime = ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
													Random random = c23a147e99f4e2aa43079a0a582fcb55b.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)cbe160155a0bbac79148ab3a24f3f70db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime));
													long num2 = (long)ca2b9801dfdd346f5dca2dabd7be377b6.c30767ddca1f9c207888833aea5b5fc61(random, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18332), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18336));
													num2 *= num2;
													num2 *= (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18340);
													int cb5905b594e11dea2f73932df = this.ca363176affcc7719c87ca60ddb5f6f34.c5a3b6934459d86d40c0d198c46e133f6(num2);
													AccTreeViewInfo accTreeViewInfo = c94516ceba74807efe1af51937197cd7e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new cd4d5a5684d153eefc4ebe1d89a85e677
													{
														cb5905b594e11dea2f73932df05981674 = cb5905b594e11dea2f73932df,
														cf87a97659111f1d1252f7e39bcac0605 = num2
													});
													cf2312b0c4a53576fb482120f0ace61d7.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo, this.cfb755cb93a73f30822ce601a125376d8);
													accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.ca56117bd7a22712111d34d4bd3aa8642 = text2;
													accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6 = text3;
													accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.caee1e47a08a4ecec009fb2516f979104 = text4;
													accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153707);
													if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text5, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153707)))
													{
														goto IL_396;
													}
													while (true)
													{
														switch (2)
														{
														case 0:
															continue;
														}
														break;
													}
													if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text5, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153667)))
													{
														goto IL_396;
													}
													while (true)
													{
														switch (6)
														{
														case 0:
															continue;
														}
														break;
													}
													if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text5, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153680)))
													{
														while (true)
														{
															switch (5)
															{
															case 0:
																continue;
															}
															goto IL_396;
														}
													}
													IL_3A4:
													cd817f0078f4e100ef0941cb6d95929ac.c26ea3c7ce5f285bcc575c946b4c282bf = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18344);
													c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text6, ref cd817f0078f4e100ef0941cb6d95929ac.c26ea3c7ce5f285bcc575c946b4c282bf);
													accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cdfd15fd9767ca3c899334e0591fc3b13 = cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref cd817f0078f4e100ef0941cb6d95929ac.c26ea3c7ce5f285bcc575c946b4c282bf);
													accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c805e30d018811e2793f3357a1dd68693 = c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text7, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(36724));
													accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfb089fcc005d120966aebcd807c953eb = text8;
													accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c43acd5b8aee8aac3eb34d311d73db4b9 = text9;
													accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c19b1d008780db8f45326d62e4ae97cf1 = text10;
													accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c5448fced558b14e475d62f73ac05a864 = text11;
													if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153707)))
													{
														goto IL_4C9;
													}
													while (true)
													{
														switch (5)
														{
														case 0:
															continue;
														}
														break;
													}
													if (!this.c211a8cb0fd0860bc469ed8ef20980300.Any(new Func<ServerTreeViewInfo, bool>(cd817f0078f4e100ef0941cb6d95929ac.cc92c189e94fbf60d0cc30dbe1fd5284a)))
													{
														goto IL_4C9;
													}
													while (true)
													{
														switch (5)
														{
														case 0:
															continue;
														}
														break;
													}
													IEnumerable<ServerTreeViewInfo> arg_4AF_0 = this.c211a8cb0fd0860bc469ed8ef20980300;
													if (func == null)
													{
														while (true)
														{
															switch (6)
															{
															case 0:
																continue;
															}
															break;
														}
														func = new Func<ServerTreeViewInfo, bool>(cd817f0078f4e100ef0941cb6d95929ac.c4fc4af6c56d1ae9de97168baaaad7ac9);
													}
													cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(arg_4AF_0.FirstOrDefault(func)), accTreeViewInfo);
													IL_623:
													int num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18356);
													IEnumerator<AccTreeViewInfo> enumerator = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b);
													try
													{
														while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
														{
															AccTreeViewInfo accTreeViewInfo2 = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator);
															if (accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac > num3)
															{
																while (true)
																{
																	switch (5)
																	{
																	case 0:
																		continue;
																	}
																	break;
																}
																num3 = accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac;
															}
														}
														while (true)
														{
															switch (4)
															{
															case 0:
																continue;
															}
															break;
														}
													}
													finally
													{
														if (enumerator != null)
														{
															while (true)
															{
																switch (6)
																{
																case 0:
																	continue;
																}
																break;
															}
															cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
														}
													}
													num3 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18360);
													accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac = num3;
													cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b, accTreeViewInfo);
													bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18364) != 0;
													try
													{
														object cdb456cfdfb988429e8ab93cb585f031e;
														cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
														accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18368) != 0);
													}
													finally
													{
														if (flag)
														{
															while (true)
															{
																switch (3)
																{
																case 0:
																	continue;
																}
																break;
															}
															object cdb456cfdfb988429e8ab93cb585f031e;
															c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
														}
													}
													this.cac383f9c4c18ddf9fcd22b48958556c9();
													this.c8299fa31317d146976f1ea9cd623369b(c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150358), text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153946)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
													continue;
													IL_4C9:
													if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153667)))
													{
														while (true)
														{
															switch (2)
															{
															case 0:
																continue;
															}
															break;
														}
														if (this.c211a8cb0fd0860bc469ed8ef20980300.Any(new Func<ServerTreeViewInfo, bool>(cd817f0078f4e100ef0941cb6d95929ac.c71dc569cf8b07858ff3813bd93caa417)))
														{
															while (true)
															{
																switch (3)
																{
																case 0:
																	continue;
																}
																break;
															}
															IEnumerable<ServerTreeViewInfo> arg_53F_0 = this.c2d1e187c9efce20e55655d518436259c;
															if (func2 == null)
															{
																while (true)
																{
																	switch (4)
																	{
																	case 0:
																		continue;
																	}
																	break;
																}
																func2 = new Func<ServerTreeViewInfo, bool>(cd817f0078f4e100ef0941cb6d95929ac.cbed718e6a8ef597fb0e1c66908d25c3c);
															}
															cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(arg_53F_0.FirstOrDefault(func2)), accTreeViewInfo);
															goto IL_623;
														}
													}
													if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153680)))
													{
														while (true)
														{
															switch (3)
															{
															case 0:
																continue;
															}
															break;
														}
														if (this.c211a8cb0fd0860bc469ed8ef20980300.Any(new Func<ServerTreeViewInfo, bool>(cd817f0078f4e100ef0941cb6d95929ac.c027c35b576e8c88a2cb4a8e5315e56d6)))
														{
															while (true)
															{
																switch (1)
																{
																case 0:
																	continue;
																}
																break;
															}
															IEnumerable<ServerTreeViewInfo> arg_5CF_0 = this.cd9db19395aea8d58426dab9ecf93bb34;
															if (func3 == null)
															{
																while (true)
																{
																	switch (3)
																	{
																	case 0:
																		continue;
																	}
																	break;
																}
																func3 = new Func<ServerTreeViewInfo, bool>(cd817f0078f4e100ef0941cb6d95929ac.c3586ef64fef39cacabfa6990543c5c4a);
															}
															cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(arg_5CF_0.FirstOrDefault(func3)), accTreeViewInfo);
															goto IL_623;
														}
													}
													cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(ceaa62c091f06923c8723464b639899db.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18348))), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18352))), accTreeViewInfo);
													goto IL_623;
													IL_396:
													accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4 = text5;
													goto IL_3A4;
												}
												this.c8299fa31317d146976f1ea9cd623369b(c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150358), text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153995)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
											}
										}
									}
								}
							}
						}
					}
				}
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				c8eb3a83832ce6b5645631aad5b3eefd1.c30767ddca1f9c207888833aea5b5fc61(textFieldParser);
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18372) != 0);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18376) != 0;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00057C20 File Offset: 0x00055E20
		private void ImportFromExcelButton_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = c357ebbb966876dcc8012637ac2b20145.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			caf3f6fde759bf8588af13067b1537ec2.c30767ddca1f9c207888833aea5b5fc61(openFileDialog, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153754));
			c4208d1ead8aba9af768229617f3d1a31.c30767ddca1f9c207888833aea5b5fc61(openFileDialog, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18380));
			c61521f76d769e0abddc65d6e14f31ad7.c30767ddca1f9c207888833aea5b5fc61(openFileDialog, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18384) != 0);
			if (cfd96c11a4b731b6425b00551c0f24764.c30767ddca1f9c207888833aea5b5fc61(openFileDialog) == (DialogResult)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18388))
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_63_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ImportFromExcelButton_Click(object, RoutedEventArgs)).MethodHandle;
				}
				string text = c937b26b91edf22459746372744691625.c30767ddca1f9c207888833aea5b5fc61(openFileDialog);
				if (cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text))
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					this.c8299fa31317d146976f1ea9cd623369b(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154030), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				}
				if (!c49b76edf1940c188fa37efd6d026df37.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153892)))
				{
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					text = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153892));
				}
				if (this.c5b4d4792b2ce59e0f6ac76386755e5a8(text))
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					this.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154081), text), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
					return;
				}
				this.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154130), text), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00057D64 File Offset: 0x00055F64
		private void hideUnusedServers_Checked(object sender, RoutedEventArgs e)
		{
			c378bc83c3b0d1bbdd8b156cfa6c703e8 arg_1C_0 = AppMain.ca691be15ac02d2fd13604941dfb1f495;
			bool? flag = ccbea4253e9b7a3696e50409b304aa41f.c30767ddca1f9c207888833aea5b5fc61(this.cbbc8bbcc1bf558ff8a0e06abd62f13d7);
			arg_1C_0.set_cbbc8bbcc1bf558ff8a0e06abd62f13d7(cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag));
			if (AppMain.c1a2627f895092b3cf57a9486ed72ee32 != null)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_3A_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.hideUnusedServers_Checked(object, RoutedEventArgs)).MethodHandle;
				}
				AppMain.c1a2627f895092b3cf57a9486ed72ee32.c853837ef992948ba870101d478d95184();
			}
			this.cac383f9c4c18ddf9fcd22b48958556c9();
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00057DBC File Offset: 0x00055FBC
		private void hideAllServers_Checked(object sender, RoutedEventArgs e)
		{
			c378bc83c3b0d1bbdd8b156cfa6c703e8 arg_1C_0 = AppMain.ca691be15ac02d2fd13604941dfb1f495;
			bool? flag = ccbea4253e9b7a3696e50409b304aa41f.c30767ddca1f9c207888833aea5b5fc61(this.c88aaa8af9bfe41a2300eab3d3ccb64f9);
			arg_1C_0.set_c88aaa8af9bfe41a2300eab3d3ccb64f9(cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag));
			if (AppMain.c1a2627f895092b3cf57a9486ed72ee32 != null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_3A_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.hideAllServers_Checked(object, RoutedEventArgs)).MethodHandle;
				}
				AppMain.c1a2627f895092b3cf57a9486ed72ee32.c853837ef992948ba870101d478d95184();
			}
			this.cac383f9c4c18ddf9fcd22b48958556c9();
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00057E14 File Offset: 0x00056014
		private void hideOfflineAccounts_Checked(object sender, RoutedEventArgs e)
		{
			c378bc83c3b0d1bbdd8b156cfa6c703e8 arg_1C_0 = AppMain.ca691be15ac02d2fd13604941dfb1f495;
			bool? flag = ccbea4253e9b7a3696e50409b304aa41f.c30767ddca1f9c207888833aea5b5fc61(this.c84d133f6e01cc85098ac63431589cbe3);
			arg_1C_0.set_c84d133f6e01cc85098ac63431589cbe3(cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag));
			if (AppMain.c1a2627f895092b3cf57a9486ed72ee32 != null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_3A_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.hideOfflineAccounts_Checked(object, RoutedEventArgs)).MethodHandle;
				}
				AppMain.c1a2627f895092b3cf57a9486ed72ee32.c853837ef992948ba870101d478d95184();
			}
			this.cac383f9c4c18ddf9fcd22b48958556c9();
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00057E6C File Offset: 0x0005606C
		private int c044ad238edc47e0f15cdb3baabef9ee6(ServerTreeViewInfo serverTreeViewInfo)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18392);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18396); i < c34fc79f1f5ac5cb60241c3525dde1524.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18404))
			{
				if (c8b792a9ba0aee1bacc58fdcdb96fcd57.c30767ddca1f9c207888833aea5b5fc61(c4dd05651878cff690977c756c17d40d0.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo), i)) == Visibility.Visible)
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_43_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c044ad238edc47e0f15cdb3baabef9ee6(ServerTreeViewInfo)).MethodHandle;
					}
					num += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18400);
				}
			}
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			return num;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00057EF4 File Offset: 0x000560F4
		internal void cac383f9c4c18ddf9fcd22b48958556c9()
		{
			try
			{
				if (!c6f7ee37dd29567ef10442c1148614a20.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_23_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.cac383f9c4c18ddf9fcd22b48958556c9()).MethodHandle;
					}
					c945f8c0caac6afd3e423205e93db941b.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), new Action(this.cac383f9c4c18ddf9fcd22b48958556c9));
				}
				else
				{
					if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c84d133f6e01cc85098ac63431589cbe3())
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						IEnumerator<AccTreeViewInfo> enumerator = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b);
						try
						{
							while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
							{
								AccTreeViewInfo accTreeViewInfo = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator);
								if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 != null)
								{
									while (true)
									{
										switch (3)
										{
										case 0:
											continue;
										}
										break;
									}
									if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.get_c6132b87d3ee6952aced554ae8aeed8be() != GameState.NotLogged)
									{
										while (true)
										{
											switch (3)
											{
											case 0:
												continue;
											}
											break;
										}
										c9712a8b2f3961caba9b0bf6ee93349f6.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18408));
										continue;
									}
								}
								c9712a8b2f3961caba9b0bf6ee93349f6.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18412));
							}
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							goto IL_14A;
						}
						finally
						{
							if (enumerator != null)
							{
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									break;
								}
								cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
							}
						}
					}
					IEnumerator<AccTreeViewInfo> enumerator2 = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b);
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator2))
						{
							AccTreeViewInfo accTreeViewInfo2 = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
							c9712a8b2f3961caba9b0bf6ee93349f6.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo2, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18416));
						}
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
						}
					}
					IL_14A:
					if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c88aaa8af9bfe41a2300eab3d3ccb64f9())
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						cc79c33ca5e15f651f8c3f5283fddae64.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, this.cd559d791bccc45933a81e7e47e42fd1b);
					}
					else
					{
						cc79c33ca5e15f651f8c3f5283fddae64.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, this.c4fc5dab2c31ad3f0faa92b746c49837e);
					}
					if (!AppMain.ca691be15ac02d2fd13604941dfb1f495.get_cbbc8bbcc1bf558ff8a0e06abd62f13d7())
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c88aaa8af9bfe41a2300eab3d3ccb64f9())
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							IEnumerator<WorldTreeViewInfo> enumerator3 = c64aaef4a72b1cca6cf3b8e689c30656c.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e);
							try
							{
								while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator3))
								{
									WorldTreeViewInfo worldTreeViewInfo = c6cb3068dd1dba97b102455710cf6a79f.c30767ddca1f9c207888833aea5b5fc61(enumerator3);
									IEnumerator<ServerTreeViewInfo> enumerator4 = c266116c92138d153032ef71f5e63e4fc.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(worldTreeViewInfo));
									try
									{
										while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator4))
										{
											ServerTreeViewInfo serverTreeViewInfo = c6ab76f0df3a33e553b2cfe7c47b9f13b.c30767ddca1f9c207888833aea5b5fc61(enumerator4);
											c18be52117135d780892993abcc9082dd.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18420));
										}
										while (true)
										{
											switch (4)
											{
											case 0:
												continue;
											}
											break;
										}
									}
									finally
									{
										if (enumerator4 != null)
										{
											while (true)
											{
												switch (7)
												{
												case 0:
													continue;
												}
												break;
											}
											cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator4);
										}
									}
									c0645beedb7d8c786fff306e018947516.c30767ddca1f9c207888833aea5b5fc61(worldTreeViewInfo, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18424));
								}
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
							}
							finally
							{
								if (enumerator3 != null)
								{
									while (true)
									{
										switch (4)
										{
										case 0:
											continue;
										}
										break;
									}
									cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator3);
								}
							}
						}
					}
					if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_cbbc8bbcc1bf558ff8a0e06abd62f13d7())
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c88aaa8af9bfe41a2300eab3d3ccb64f9())
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							IEnumerator<WorldTreeViewInfo> enumerator5 = c64aaef4a72b1cca6cf3b8e689c30656c.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e);
							try
							{
								while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator5))
								{
									WorldTreeViewInfo worldTreeViewInfo2 = c6cb3068dd1dba97b102455710cf6a79f.c30767ddca1f9c207888833aea5b5fc61(enumerator5);
									int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18428);
									IEnumerator<ServerTreeViewInfo> enumerator6 = c266116c92138d153032ef71f5e63e4fc.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(worldTreeViewInfo2));
									try
									{
										while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator6))
										{
											ServerTreeViewInfo serverTreeViewInfo2 = c6ab76f0df3a33e553b2cfe7c47b9f13b.c30767ddca1f9c207888833aea5b5fc61(enumerator6);
											int num2 = this.c044ad238edc47e0f15cdb3baabef9ee6(serverTreeViewInfo2);
											num += num2;
											if (num2 == 0)
											{
												while (true)
												{
													switch (5)
													{
													case 0:
														continue;
													}
													break;
												}
												c18be52117135d780892993abcc9082dd.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo2, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18432));
											}
											else
											{
												c18be52117135d780892993abcc9082dd.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo2, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18436));
											}
										}
										while (true)
										{
											switch (2)
											{
											case 0:
												continue;
											}
											break;
										}
									}
									finally
									{
										if (enumerator6 != null)
										{
											while (true)
											{
												switch (1)
												{
												case 0:
													continue;
												}
												break;
											}
											cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator6);
										}
									}
									if (num == 0)
									{
										while (true)
										{
											switch (3)
											{
											case 0:
												continue;
											}
											break;
										}
										c0645beedb7d8c786fff306e018947516.c30767ddca1f9c207888833aea5b5fc61(worldTreeViewInfo2, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18440));
									}
									else
									{
										c0645beedb7d8c786fff306e018947516.c30767ddca1f9c207888833aea5b5fc61(worldTreeViewInfo2, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18444));
									}
								}
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									break;
								}
							}
							finally
							{
								if (enumerator5 != null)
								{
									while (true)
									{
										switch (3)
										{
										case 0:
											continue;
										}
										break;
									}
									cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator5);
								}
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0005837C File Offset: 0x0005657C
		private void Mi2_Click(object sender, RoutedEventArgs e)
		{
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			if (accTreeViewInfo != null)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_2D_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.Mi2_Click(object, RoutedEventArgs)).MethodHandle;
				}
				if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 == null)
				{
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					if (c7149d99595dd0da0305bdacf045443ba.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154205), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154232), (MessageBoxButton)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18448)) != (MessageBoxResult)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18452))
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						return;
					}
					IEnumerator<WorldTreeViewInfo> enumerator = c64aaef4a72b1cca6cf3b8e689c30656c.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e);
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
						{
							WorldTreeViewInfo worldTreeViewInfo = c6cb3068dd1dba97b102455710cf6a79f.c30767ddca1f9c207888833aea5b5fc61(enumerator);
							IEnumerator<ServerTreeViewInfo> enumerator2 = c266116c92138d153032ef71f5e63e4fc.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(worldTreeViewInfo));
							try
							{
								while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator2))
								{
									ServerTreeViewInfo serverTreeViewInfo = c6ab76f0df3a33e553b2cfe7c47b9f13b.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
									c3118a9e6b2e6153bc5661d815a17e763.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo), accTreeViewInfo);
								}
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
							}
							finally
							{
								if (enumerator2 != null)
								{
									while (true)
									{
										switch (4)
										{
										case 0:
											continue;
										}
										break;
									}
									cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
								}
							}
						}
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
						}
					}
					c3118a9e6b2e6153bc5661d815a17e763.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b, accTreeViewInfo);
					this.ca363176affcc7719c87ca60ddb5f6f34.cb39f16a874c8e61e4498446609b770ac(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb5905b594e11dea2f73932df05981674);
					this.cac383f9c4c18ddf9fcd22b48958556c9();
				}
			}
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x000584F4 File Offset: 0x000566F4
		private void Mi6_Click(object sender, RoutedEventArgs e)
		{
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			if (accTreeViewInfo != null)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_2A_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.Mi6_Click(object, RoutedEventArgs)).MethodHandle;
				}
				if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 != null)
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.c5e071fc90b6534e9e9071f415f5b7deb();
				}
			}
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0005854C File Offset: 0x0005674C
		private void Mi1_Click(object sender, RoutedEventArgs e)
		{
			ServerTreeViewInfo serverTreeViewInfo = cc272f7f9b9c40a31ad01733e88382568.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			if (serverTreeViewInfo != null)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_2D_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.Mi1_Click(object, RoutedEventArgs)).MethodHandle;
				}
				DateTime dateTime = ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Random random = c23a147e99f4e2aa43079a0a582fcb55b.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)cbe160155a0bbac79148ab3a24f3f70db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime));
				long num = (long)ca2b9801dfdd346f5dca2dabd7be377b6.c30767ddca1f9c207888833aea5b5fc61(random, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18456), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18460));
				num *= num;
				num *= (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18464);
				int cb5905b594e11dea2f73932df = this.ca363176affcc7719c87ca60ddb5f6f34.c5a3b6934459d86d40c0d198c46e133f6(num);
				cd4d5a5684d153eefc4ebe1d89a85e677 cd4d5a5684d153eefc4ebe1d89a85e = new cd4d5a5684d153eefc4ebe1d89a85e677();
				cd4d5a5684d153eefc4ebe1d89a85e.cb5905b594e11dea2f73932df05981674 = cb5905b594e11dea2f73932df;
				cd4d5a5684d153eefc4ebe1d89a85e.cf87a97659111f1d1252f7e39bcac0605 = num;
				AccTreeViewInfo accTreeViewInfo = c94516ceba74807efe1af51937197cd7e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd4d5a5684d153eefc4ebe1d89a85e);
				cf2312b0c4a53576fb482120f0ace61d7.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo, this.cfb755cb93a73f30822ce601a125376d8);
				accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.ca56117bd7a22712111d34d4bd3aa8642 = cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154261), cd4d5a5684d153eefc4ebe1d89a85e.cb5905b594e11dea2f73932df05981674);
				c8ccf32dc3bb8537a64795414cd54b8e1.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.ca56117bd7a22712111d34d4bd3aa8642);
				int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18468);
				while (i < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300))
				{
					if (c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, i) == serverTreeViewInfo)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153707);
						accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cdfd15fd9767ca3c899334e0591fc3b13 = c4fb5da867a6dcef965e83d2e660c0364.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, i).cb5905b594e11dea2f73932df05981674);
						cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, i)), accTreeViewInfo);
						IL_1AD:
						int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18476);
						while (j < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c))
						{
							if (c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, j) == serverTreeViewInfo)
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153667);
								accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cdfd15fd9767ca3c899334e0591fc3b13 = c4fb5da867a6dcef965e83d2e660c0364.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, j).cb5905b594e11dea2f73932df05981674);
								cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, j)), accTreeViewInfo);
								IL_265:
								for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18484); k < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18488))
								{
									if (c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, k) == serverTreeViewInfo)
									{
										while (true)
										{
											switch (2)
											{
											case 0:
												continue;
											}
											break;
										}
										accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153680);
										accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cdfd15fd9767ca3c899334e0591fc3b13 = c4fb5da867a6dcef965e83d2e660c0364.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, k).cb5905b594e11dea2f73932df05981674);
										cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, k)), accTreeViewInfo);
										IL_31D:
										if (serverTreeViewInfo.cb5905b594e11dea2f73932df05981674 == 0)
										{
											while (true)
											{
												switch (7)
												{
												case 0:
													continue;
												}
												break;
											}
											cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo), accTreeViewInfo);
										}
										int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18492);
										IEnumerator<AccTreeViewInfo> enumerator = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b);
										try
										{
											while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
											{
												AccTreeViewInfo accTreeViewInfo2 = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator);
												if (accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac > num2)
												{
													while (true)
													{
														switch (7)
														{
														case 0:
															continue;
														}
														break;
													}
													num2 = accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac;
												}
											}
											while (true)
											{
												switch (7)
												{
												case 0:
													continue;
												}
												break;
											}
										}
										finally
										{
											if (enumerator != null)
											{
												while (true)
												{
													switch (3)
													{
													case 0:
														continue;
													}
													break;
												}
												cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
											}
										}
										num2 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18496);
										accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac = num2;
										cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b, accTreeViewInfo);
										bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18500) != 0;
										try
										{
											object cdb456cfdfb988429e8ab93cb585f031e;
											cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
											accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18504) != 0);
										}
										finally
										{
											if (flag)
											{
												while (true)
												{
													switch (7)
													{
													case 0:
														continue;
													}
													break;
												}
												object cdb456cfdfb988429e8ab93cb585f031e;
												c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
											}
										}
										this.cac383f9c4c18ddf9fcd22b48958556c9();
										return;
									}
								}
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									goto IL_31D;
								}
							}
							else
							{
								j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18480);
							}
						}
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							goto IL_265;
						}
					}
					else
					{
						i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18472);
					}
				}
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					goto IL_1AD;
				}
			}
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000589A8 File Offset: 0x00056BA8
		private void timerTick(object sender, EventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.timerTick(object, EventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			this.c868c67d6fc0d52fc8a7700bde517c483(accTreeViewInfo, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18508) != 0);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00058A20 File Offset: 0x00056C20
		private void schedulerInfo_PreviewMouseDown(object sender, MouseButtonEventArgs e)
		{
			try
			{
				cbf4111912aed594f2b4372828dd95aa3.c5d9d07cc750d812b82f036c97aa9630c c5d9d07cc750d812b82f036c97aa9630c = new cbf4111912aed594f2b4372828dd95aa3.c5d9d07cc750d812b82f036c97aa9630c();
				c5d9d07cc750d812b82f036c97aa9630c.cb6ea3d298d68be569f5410cc290458d5 = this;
				if (c0ec777c2c26b413663d41f7588f43357.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68) != null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_2E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.schedulerInfo_PreviewMouseDown(object, MouseButtonEventArgs)).MethodHandle;
					}
					if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68) < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18512))
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					else
					{
						System.Windows.Controls.DataGrid dataGrid = cc1265596f19cee0b0a3e80d7e471ea56.cea69e7c4d1a729bd5783221de1566e79(sender);
						System.Windows.Point point = c7b821b89ee3ce02e1dc9ae56e4dfbf92.c30767ddca1f9c207888833aea5b5fc61(e, dataGrid);
						c5d9d07cc750d812b82f036c97aa9630c.c47dc92cd06388f50f3ac3727d2ccc67d = c6c455a540db9f8c3ca299e080f4abc56.c8a754f5f2ca4adde825691a9c31a0e83;
						c7e436bd58d99b7d1e136edd744fc68f0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(dataGrid, null, new HitTestResultCallback(c5d9d07cc750d812b82f036c97aa9630c.c4f8275e2c0709d49ce2c844671851ab7), c707db64078854bf51799bd579066fbf9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(point));
						if (c5d9d07cc750d812b82f036c97aa9630c.c47dc92cd06388f50f3ac3727d2ccc67d == null)
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18516) != 0);
							c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c8d495e9cc44c58f78c66024676ad9a57, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18520) != 0);
							c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c137952fe128ebb66ae21d036d05ec47c, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18524) != 0);
						}
						else
						{
							cc401045b2d3a107c5397ce08b50b21f0 cc401045b2d3a107c5397ce08b50b21f = c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(cf7d37206ae0418ab99a111709550887a.cea69e7c4d1a729bd5783221de1566e79(c0a45cc948868ba6185f93c52b725dd87.c30767ddca1f9c207888833aea5b5fc61(c5d9d07cc750d812b82f036c97aa9630c.c47dc92cd06388f50f3ac3727d2ccc67d)));
							c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18528) != 0);
							c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c8d495e9cc44c58f78c66024676ad9a57, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18532) != 0);
							c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c137952fe128ebb66ae21d036d05ec47c, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18536) != 0);
							c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86, cc401045b2d3a107c5397ce08b50b21f.c3ec335a884e0e805a58881f2832c8af0);
							cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.c8d495e9cc44c58f78c66024676ad9a57, this.c0698629fc08d683fc1fe8d82ce5e8fda(cc401045b2d3a107c5397ce08b50b21f.c04f3a1ba94cd5bf5ae9908d00de8f369));
							cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.c137952fe128ebb66ae21d036d05ec47c, this.c0698629fc08d683fc1fe8d82ce5e8fda(cc401045b2d3a107c5397ce08b50b21f.cda9f7f94b127e0b9c034e056d128a2a6));
						}
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00058BE4 File Offset: 0x00056DE4
		public bool c1e589ac84f528506f6ed36a40e2aa928(string text)
		{
			Regex regex = cb942cecd6de439460cc69a3ef635ecab.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154284));
			return cefb80a3d0dc94cca8a3cf2453ef72a43.c30767ddca1f9c207888833aea5b5fc61(regex, text);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00058C10 File Offset: 0x00056E10
		private string c0698629fc08d683fc1fe8d82ce5e8fda(int num)
		{
			int num2 = num / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18540);
			int num3 = num - num2 * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18544);
			return c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(121794)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(121794)));
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00058C78 File Offset: 0x00056E78
		public void c5137cf89d9148f17cc4ecfe0744db567(int num)
		{
			List<cc401045b2d3a107c5397ce08b50b21f0> list = this.ca363176affcc7719c87ca60ddb5f6f34.ce9dcf69fbd8c0e6fd7f4fa7272c0ceb7(num);
			cbfa19a62943d23dc53ac73bcaa2e7ca4.c30767ddca1f9c207888833aea5b5fc61(cceb8b6cda797b5d3dd47c135717cf0a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18548); i < ca17defc9d21ff196f1b5a0e36a4a122c.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18552))
			{
				object expr_32 = cceb8b6cda797b5d3dd47c135717cf0a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				SchedulerInfo schedulerInfo = c22853cb1a2cc8a74af890760bcb782be.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				c3b1387bfefb4ab72d330e2d04ff7a5b9.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, this.ca363176affcc7719c87ca60ddb5f6f34);
				ced62e28aa9ec991708c915e85c294a03.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, cec12075865112a9b720ad4093180e1a5.c30767ddca1f9c207888833aea5b5fc61(list, i));
				cfe84b5ba766529a8b76bd47c7afc040f.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, cec12075865112a9b720ad4093180e1a5.c30767ddca1f9c207888833aea5b5fc61(list, i).c60c0eb2e26a4f9af0ed98ae796effea1);
				c5c8f67f2258478e63d20858b8d96d768.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c3980231756d98f77b332e12a7eea1cf0.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86), cec12075865112a9b720ad4093180e1a5.c30767ddca1f9c207888833aea5b5fc61(list, i).c3ec335a884e0e805a58881f2832c8af0)));
				c84c669949e419ff908bc018fcbddbf8b.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c0698629fc08d683fc1fe8d82ce5e8fda(cec12075865112a9b720ad4093180e1a5.c30767ddca1f9c207888833aea5b5fc61(list, i).c04f3a1ba94cd5bf5ae9908d00de8f369), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154353), this.c0698629fc08d683fc1fe8d82ce5e8fda(cec12075865112a9b720ad4093180e1a5.c30767ddca1f9c207888833aea5b5fc61(list, i).cda9f7f94b127e0b9c034e056d128a2a6)));
				cf72024de6a3187d76f598dccb41cb0db.c30767ddca1f9c207888833aea5b5fc61(expr_32, schedulerInfo);
			}
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			if (!true)
			{
				RuntimeMethodHandle arg_112_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c5137cf89d9148f17cc4ecfe0744db567(int)).MethodHandle;
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00058D98 File Offset: 0x00056F98
		private void pluginsList_PreviewMouseDown(object sender, MouseButtonEventArgs e)
		{
			try
			{
				cbf4111912aed594f2b4372828dd95aa3.cfd399d684d99ddae7d7f6b3323f10340 cfd399d684d99ddae7d7f6b3323f = new cbf4111912aed594f2b4372828dd95aa3.cfd399d684d99ddae7d7f6b3323f10340();
				cfd399d684d99ddae7d7f6b3323f.cb6ea3d298d68be569f5410cc290458d5 = this;
				if (c0ec777c2c26b413663d41f7588f43357.c30767ddca1f9c207888833aea5b5fc61(this.cfc72e1593fda015b04d1c33a1c5ae79d) == null)
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_30_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.pluginsList_PreviewMouseDown(object, MouseButtonEventArgs)).MethodHandle;
					}
				}
				else if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				else if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				else
				{
					AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
					System.Windows.Controls.DataGrid dataGrid = cc1265596f19cee0b0a3e80d7e471ea56.cea69e7c4d1a729bd5783221de1566e79(sender);
					System.Windows.Point point = c7b821b89ee3ce02e1dc9ae56e4dfbf92.c30767ddca1f9c207888833aea5b5fc61(e, dataGrid);
					cfd399d684d99ddae7d7f6b3323f.c47dc92cd06388f50f3ac3727d2ccc67d = c6c455a540db9f8c3ca299e080f4abc56.c8a754f5f2ca4adde825691a9c31a0e83;
					c7e436bd58d99b7d1e136edd744fc68f0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(dataGrid, null, new HitTestResultCallback(cfd399d684d99ddae7d7f6b3323f.cd84862e5eb9e327e5e99c17b42bb4ea3), c707db64078854bf51799bd579066fbf9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(point));
					if (cfd399d684d99ddae7d7f6b3323f.c47dc92cd06388f50f3ac3727d2ccc67d == null)
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					else if (c184a3e8cae57b07818a06975208ee220.c30767ddca1f9c207888833aea5b5fc61(c2e0295a73d91e0a1e4a78972d82bfb54.c30767ddca1f9c207888833aea5b5fc61(cfd399d684d99ddae7d7f6b3323f.c47dc92cd06388f50f3ac3727d2ccc67d)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18556))
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
						string text = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(22);
						string text2 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149373);
						string text3 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(48610);
						if (c3aefd2642b686bcd2b9eb5c3fb1e6ace.cea69e7c4d1a729bd5783221de1566e79(c0a45cc948868ba6185f93c52b725dd87.c30767ddca1f9c207888833aea5b5fc61(cfd399d684d99ddae7d7f6b3323f.c47dc92cd06388f50f3ac3727d2ccc67d)).c120a76db91f7ca7eaf3a592702bd8b58)
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							try
							{
								Type type = ca91d21069c5b692ab95faf05f524cf96.c30767ddca1f9c207888833aea5b5fc61(c3aefd2642b686bcd2b9eb5c3fb1e6ace.cea69e7c4d1a729bd5783221de1566e79(c0a45cc948868ba6185f93c52b725dd87.c30767ddca1f9c207888833aea5b5fc61(cfd399d684d99ddae7d7f6b3323f.c47dc92cd06388f50f3ac3727d2ccc67d)).c9dfc5b53e96e74107a360b871efedc7f);
								MethodInfo methodInfo = ca04d7eb394b092826e5a0c49d44009e8.c30767ddca1f9c207888833aea5b5fc61(type, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149388));
								MethodInfo methodInfo2 = ca04d7eb394b092826e5a0c49d44009e8.c30767ddca1f9c207888833aea5b5fc61(type, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149419));
								MethodInfo methodInfo3 = ca04d7eb394b092826e5a0c49d44009e8.c30767ddca1f9c207888833aea5b5fc61(type, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149452));
								if (c8200be59554d5602fa580635c1e81d13.c0cf59c3e67a46fd4edb3040c5ab0bbfb(methodInfo, c1de0a6423204725d1d8e4dab4ae56fd1.c8a754f5f2ca4adde825691a9c31a0e83))
								{
									while (true)
									{
										switch (1)
										{
										case 0:
											continue;
										}
										break;
									}
									text = c5bdadb216ff81200f68025e2298d040e.c9963fcf210a214a3206d6500f3b9397b(c92e7a996a6c251fd4825d06c32029762.c30767ddca1f9c207888833aea5b5fc61(methodInfo, null, cd01a27e45510a277b943745993be6da3.c8a754f5f2ca4adde825691a9c31a0e83));
								}
								if (c8200be59554d5602fa580635c1e81d13.c0cf59c3e67a46fd4edb3040c5ab0bbfb(methodInfo2, c1de0a6423204725d1d8e4dab4ae56fd1.c8a754f5f2ca4adde825691a9c31a0e83))
								{
									while (true)
									{
										switch (1)
										{
										case 0:
											continue;
										}
										break;
									}
									text2 = c5bdadb216ff81200f68025e2298d040e.c9963fcf210a214a3206d6500f3b9397b(c92e7a996a6c251fd4825d06c32029762.c30767ddca1f9c207888833aea5b5fc61(methodInfo2, null, cd01a27e45510a277b943745993be6da3.c8a754f5f2ca4adde825691a9c31a0e83));
								}
								if (c8200be59554d5602fa580635c1e81d13.c0cf59c3e67a46fd4edb3040c5ab0bbfb(methodInfo3, c1de0a6423204725d1d8e4dab4ae56fd1.c8a754f5f2ca4adde825691a9c31a0e83))
								{
									while (true)
									{
										switch (3)
										{
										case 0:
											continue;
										}
										break;
									}
									text3 = c5bdadb216ff81200f68025e2298d040e.c9963fcf210a214a3206d6500f3b9397b(c92e7a996a6c251fd4825d06c32029762.c30767ddca1f9c207888833aea5b5fc61(methodInfo3, null, cd01a27e45510a277b943745993be6da3.c8a754f5f2ca4adde825691a9c31a0e83));
								}
								goto IL_2B6;
							}
							catch (Exception ex)
							{
								cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
								goto IL_2B6;
							}
						}
						new ca1091f499e678637b163d556b1303498(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33558), cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(c3aefd2642b686bcd2b9eb5c3fb1e6ace.cea69e7c4d1a729bd5783221de1566e79(c0a45cc948868ba6185f93c52b725dd87.c30767ddca1f9c207888833aea5b5fc61(cfd399d684d99ddae7d7f6b3323f.c47dc92cd06388f50f3ac3727d2ccc67d)))), ref text, ref text2, ref text3);
						IL_2B6:
						cce9c6970ae3314a1c0a269eb03d3cfa1.c30767ddca1f9c207888833aea5b5fc61(this.c155f664c997c9a5d6c158781375a2796, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154360), text));
						cce9c6970ae3314a1c0a269eb03d3cfa1.c30767ddca1f9c207888833aea5b5fc61(this.c86691c3d7259507eaad34cf7705ae6fd, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154391), text2));
						cce9c6970ae3314a1c0a269eb03d3cfa1.c30767ddca1f9c207888833aea5b5fc61(this.c13885786862bdc36510c4781ec731c97, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154420), text3));
					}
					else if (c184a3e8cae57b07818a06975208ee220.c30767ddca1f9c207888833aea5b5fc61(c2e0295a73d91e0a1e4a78972d82bfb54.c30767ddca1f9c207888833aea5b5fc61(cfd399d684d99ddae7d7f6b3323f.c47dc92cd06388f50f3ac3727d2ccc67d)) == 0)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 != null)
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
							PluginInfoDataGrid pluginInfoDataGrid = c3aefd2642b686bcd2b9eb5c3fb1e6ace.cea69e7c4d1a729bd5783221de1566e79(c0a45cc948868ba6185f93c52b725dd87.c30767ddca1f9c207888833aea5b5fc61(cfd399d684d99ddae7d7f6b3323f.c47dc92cd06388f50f3ac3727d2ccc67d));
							if (pluginInfoDataGrid.c120a76db91f7ca7eaf3a592702bd8b58)
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								if ((int)c34f66a69faa8b893054328b46e2ec049.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18560))
								{
									while (true)
									{
										switch (5)
										{
										case 0:
											continue;
										}
										break;
									}
									accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.ce16be0a18e58efea74300321215d71ff(cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid));
								}
								else if ((int)c34f66a69faa8b893054328b46e2ec049.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18564))
								{
									while (true)
									{
										switch (1)
										{
										case 0:
											continue;
										}
										break;
									}
									accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.c039a7ca93246504cd7a134547a2b0228(cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid), pluginInfoDataGrid.c9dfc5b53e96e74107a360b871efedc7f);
								}
							}
							else if ((int)c34f66a69faa8b893054328b46e2ec049.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18568))
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.c5dc88e4d90bd10c13d5a420a5ec54447(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33558), cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid)));
							}
							else if ((int)c34f66a69faa8b893054328b46e2ec049.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18572))
							{
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									break;
								}
								accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.c63d99ae51ee15a51df98c28c9a9278fa(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33558), cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid)));
							}
							this.c868c67d6fc0d52fc8a7700bde517c483(accTreeViewInfo, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18576) != 0);
						}
					}
				}
			}
			catch (Exception ex2)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2));
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000592A4 File Offset: 0x000574A4
		private string cccd5cbc3d8eb61a5107082cf91ebdbeb(ulong num)
		{
			DateTime dateTime = cc4987d6a853db77954f21abe4e42946a.cc9ac066cf01d912d638f598a5f7acdcc(num);
			if (c06c0a9ebf35736beea1e026dc49e9b37.c0cf59c3e67a46fd4edb3040c5ab0bbfb(dateTime, ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb()))
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_2E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.cccd5cbc3d8eb61a5107082cf91ebdbeb(ulong)).MethodHandle;
				}
				TimeSpan timeSpan = c35ed2a6cd5aee97721789937d72dec8d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(dateTime, ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
				int num2 = c38e3100f63e637ed70403b5e944996d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref timeSpan);
				string expr_50 = cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num2);
				string expr_5C = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154449);
				int num3 = cf8912abee2fb65e31d992a04dbd253d0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref timeSpan);
				return c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_50, expr_5C, cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num3), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154464));
			}
			return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154479);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00059344 File Offset: 0x00057544
		private string ce317392354826cc825d698648ff5c621(ulong num)
		{
			DateTime dateTime = cc4987d6a853db77954f21abe4e42946a.cc9ac066cf01d912d638f598a5f7acdcc(num);
			if (c06c0a9ebf35736beea1e026dc49e9b37.c0cf59c3e67a46fd4edb3040c5ab0bbfb(dateTime, ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb()))
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_2E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ce317392354826cc825d698648ff5c621(ulong)).MethodHandle;
				}
				TimeSpan timeSpan = c35ed2a6cd5aee97721789937d72dec8d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(dateTime, ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
				int num2 = c38e3100f63e637ed70403b5e944996d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref timeSpan);
				return cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num2), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154500));
			}
			return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153576);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x000593C4 File Offset: 0x000575C4
		internal void c6866c3f94257a47c85026e375e297438()
		{
			while (true)
			{
				try
				{
					cbf4111912aed594f2b4372828dd95aa3.c1b335898911b58d721104396217b5d94 c1b335898911b58d721104396217b5d = new cbf4111912aed594f2b4372828dd95aa3.c1b335898911b58d721104396217b5d94();
					c1b335898911b58d721104396217b5d.cb6ea3d298d68be569f5410cc290458d5 = this;
					this.cac383f9c4c18ddf9fcd22b48958556c9();
					c1b335898911b58d721104396217b5d.c358790ce1997e11a2edc326a8a5965f7 = c2aa93f14f02daf7434a6dc4f4f6c363a.c8a754f5f2ca4adde825691a9c31a0e83;
					c945f8c0caac6afd3e423205e93db941b.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7), new Action(c1b335898911b58d721104396217b5d.c3df32bcf069e3635c279c2e6d25a6540));
					IEnumerator<AccTreeViewInfo> enumerator = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b);
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
						{
							Action action = c2cffb0c8c347f2a1edaa1274b624dbd1.c8a754f5f2ca4adde825691a9c31a0e83;
							cbf4111912aed594f2b4372828dd95aa3.c667dd7d578392b64f2ae1cb91ee6686a c667dd7d578392b64f2ae1cb91ee6686a = new cbf4111912aed594f2b4372828dd95aa3.c667dd7d578392b64f2ae1cb91ee6686a();
							c667dd7d578392b64f2ae1cb91ee6686a.cdbac995d0b545ca0718574d33380e861 = c1b335898911b58d721104396217b5d;
							c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9 = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator);
							if (c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.cc442622fc18861728248f70298b36dc7)
							{
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
								if (!true)
								{
									RuntimeMethodHandle arg_9B_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c6866c3f94257a47c85026e375e297438()).MethodHandle;
								}
								cf2312b0c4a53576fb482120f0ace61d7.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.cb9bcf976186c79f4c709eebcd63eda46);
							}
							else if (c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9 == null)
							{
								while (true)
								{
									switch (6)
									{
									case 0:
										continue;
									}
									break;
								}
								cf2312b0c4a53576fb482120f0ace61d7.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.cfb755cb93a73f30822ce601a125376d8);
							}
							else
							{
								if (c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0() != null)
								{
									while (true)
									{
										switch (3)
										{
										case 0:
											continue;
										}
										break;
									}
									if ((int)c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c6132b87d3ee6952aced554ae8aeed8be() != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18580))
									{
										while (true)
										{
											switch (2)
											{
											case 0:
												continue;
											}
											break;
										}
										if ((int)c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c6132b87d3ee6952aced554ae8aeed8be() != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18584))
										{
											goto IL_19D;
										}
										while (true)
										{
											switch (6)
											{
											case 0:
												continue;
											}
											break;
										}
									}
									if (c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.c64bef5a9adcd4e1241713da72257eda3())
									{
										while (true)
										{
											switch (6)
											{
											case 0:
												continue;
											}
											break;
										}
										cf2312b0c4a53576fb482120f0ace61d7.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.c8de530f3e6382d3b2f91780631d61919);
										goto IL_1AF;
									}
									cf2312b0c4a53576fb482120f0ace61d7.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.c191cc919d4f42dd5a800d55c995e0acd);
									goto IL_1AF;
								}
								IL_19D:
								cf2312b0c4a53576fb482120f0ace61d7.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.c9a1aad0eb9412e7785834b30ef2fef12);
							}
							IL_1AF:
							if (c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9 != null)
							{
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									break;
								}
								ulong num = c94c1a2de340d4610b15ee7b04dc7f985.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9);
								if (num != c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c4059fe7fb67522e038fb94baf8150674)
								{
									while (true)
									{
										switch (1)
										{
										case 0:
											continue;
										}
										break;
									}
									c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c4059fe7fb67522e038fb94baf8150674 = num;
									using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.cdb456cfdfb988429e8ab93cb585f031e))
									{
										c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18588) != 0);
									}
								}
								if (c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0() != null)
								{
									while (true)
									{
										switch (4)
										{
										case 0:
											continue;
										}
										break;
									}
									int num2 = c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.c4196d4f1f84ad4f2e6aec391f233acdd();
									long num3 = c3baabff6530900a0bbfe2871136f9458.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
									int num4 = c6fedc4467e28345e91885c5bc94bab7b.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
									if (num2 == c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.cab75189cbbf8f77be131afc306254891)
									{
										while (true)
										{
											switch (6)
											{
											case 0:
												continue;
											}
											break;
										}
										if (num3 == (long)c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.cca5ded226e650778b7fe76464af7cdcd)
										{
											while (true)
											{
												switch (4)
												{
												case 0:
													continue;
												}
												break;
											}
											if (num4 == c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c084849f9701722a8a82ccb51e3567e62)
											{
												while (true)
												{
													switch (7)
													{
													case 0:
														continue;
													}
													break;
												}
												if (!c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.c9e60c04d8f9c06f98c7605c375d95674, c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c5b1995a63fedd9443b419598ca3ea08f))
												{
													goto IL_3DF;
												}
												while (true)
												{
													switch (3)
													{
													case 0:
														continue;
													}
													break;
												}
											}
										}
									}
									c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.cab75189cbbf8f77be131afc306254891 = num2;
									c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.cca5ded226e650778b7fe76464af7cdcd = (int)num3;
									c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c084849f9701722a8a82ccb51e3567e62 = num4;
									c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c5b1995a63fedd9443b419598ca3ea08f = c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.c9e60c04d8f9c06f98c7605c375d95674;
									using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.cdb456cfdfb988429e8ab93cb585f031e))
									{
										c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18592) != 0);
									}
								}
							}
							IL_3DF:
							if (c1b335898911b58d721104396217b5d.c358790ce1997e11a2edc326a8a5965f7 != null)
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								if (c1b335898911b58d721104396217b5d.c358790ce1997e11a2edc326a8a5965f7 == c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9)
								{
									while (true)
									{
										switch (3)
										{
										case 0:
											continue;
										}
										break;
									}
									object expr_412 = ce430ef4c9c97ad6b9f660180ee5ee436.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
									if (action == null)
									{
										while (true)
										{
											switch (4)
											{
											case 0:
												continue;
											}
											break;
										}
										action = new Action(c667dd7d578392b64f2ae1cb91ee6686a.c5b980dc62b2f1c4b7b77e1e2056cfed1);
									}
									c945f8c0caac6afd3e423205e93db941b.c30767ddca1f9c207888833aea5b5fc61(expr_412, action);
								}
							}
							if (c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9 == null)
							{
								goto IL_6DC;
							}
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0() == null)
							{
								goto IL_6DC;
							}
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							c80cbf954b68705fd4f4c9444c3244540.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18596));
							object arg_4F0_0 = c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9;
							string expr_49C = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150358);
							byte b = c1ff51920b6c6ebf6ba641ffd73637719.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
							c117aba036e5aa4635815cd1ee544d481.c30767ddca1f9c207888833aea5b5fc61(arg_4F0_0, c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_49C, c4fb5da867a6dcef965e83d2e660c0364.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref b), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154503), ccee71b5f426d96b55fbc710d66688b7f.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0())));
							object arg_53B_0 = c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9;
							double num5 = (double)c3baabff6530900a0bbfe2871136f9458.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(18600);
							c9c2f29495620e155289e227addaba2fa.c30767ddca1f9c207888833aea5b5fc61(arg_53B_0, cd26c1ed86899b91c17e61188444ccd80.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num5, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154508)));
							c11aa2c9001e0b0d08b0be39e4c7a7e6a.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb((double)ce7a2a2bd5a314372d9c4632e238ba81a.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) / ((double)c4cc0c9b7884352beee20bc8f20093aaa.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(18608)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(18616)));
							object arg_5D0_0 = c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9;
							int num6 = c6fedc4467e28345e91885c5bc94bab7b.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
							c73eaf9921d3b04d1d70ab63fca88b58b.c30767ddca1f9c207888833aea5b5fc61(arg_5D0_0, cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num6));
							c7ad9a3081009d8332d54258ebef775a4.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.ce317392354826cc825d698648ff5c621(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c4059fe7fb67522e038fb94baf8150674));
							object arg_626_0 = c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9;
							int num7 = c8eaea7e2c393db22f4e87cceae80c8e7.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
							c6494cf8e4f6c7e8299913bb91abdcd6e.c30767ddca1f9c207888833aea5b5fc61(arg_626_0, cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num7));
							if (c8eaea7e2c393db22f4e87cceae80c8e7.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18624))
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								c98397226523acb492bb1fbcec8806d31.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.c0d8c68555854f07d401b833fcf35300e);
							}
							else
							{
								c98397226523acb492bb1fbcec8806d31.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.cd2322d00bb2b1846e002c867c614232d);
							}
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca465476552057253c5be428d1f336db2.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153576)))
							{
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									break;
								}
								cffdb18d831d7f75053ca8b9f6bf2fc64.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.c1d19582cffe423a1124756d0fe13de8d);
							}
							else
							{
								cffdb18d831d7f75053ca8b9f6bf2fc64.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.c3c897f76a0f75ab801de66894978eafa);
							}
							IL_8E6:
							if (c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.c12116d955c4a50d0c519dc70dbd73d1f)
							{
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
								bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18664) != 0;
								try
								{
									object cdb456cfdfb988429e8ab93cb585f031e;
									cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
									this.ca363176affcc7719c87ca60ddb5f6f34.c71e1391e4879797b178d1ababd42a134(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430);
									c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18668) != 0);
								}
								finally
								{
									if (flag)
									{
										while (true)
										{
											switch (3)
											{
											case 0:
												continue;
											}
											break;
										}
										object cdb456cfdfb988429e8ab93cb585f031e;
										c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
									}
								}
								continue;
							}
							continue;
							IL_6DC:
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c5b1995a63fedd9443b419598ca3ea08f, ""))
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								object arg_7C3_0 = c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9;
								object[] array = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18628));
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18632)] = c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac;
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18636)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150358);
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18640)] = cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.cab75189cbbf8f77be131afc306254891);
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18644)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154503);
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18648)] = c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c5b1995a63fedd9443b419598ca3ea08f;
								c117aba036e5aa4635815cd1ee544d481.c30767ddca1f9c207888833aea5b5fc61(arg_7C3_0, c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array));
							}
							object arg_805_0 = c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9;
							double num8 = (double)c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.cca5ded226e650778b7fe76464af7cdcd / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(18652);
							c9c2f29495620e155289e227addaba2fa.c30767ddca1f9c207888833aea5b5fc61(arg_805_0, cd26c1ed86899b91c17e61188444ccd80.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num8, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151020)));
							c73eaf9921d3b04d1d70ab63fca88b58b.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c084849f9701722a8a82ccb51e3567e62));
							c80cbf954b68705fd4f4c9444c3244540.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18660));
							c7ad9a3081009d8332d54258ebef775a4.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.ce317392354826cc825d698648ff5c621(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c4059fe7fb67522e038fb94baf8150674));
							c6494cf8e4f6c7e8299913bb91abdcd6e.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138673));
							c98397226523acb492bb1fbcec8806d31.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.cd2322d00bb2b1846e002c867c614232d);
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca465476552057253c5be428d1f336db2.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153576)))
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								cffdb18d831d7f75053ca8b9f6bf2fc64.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.c1d19582cffe423a1124756d0fe13de8d);
								goto IL_8E6;
							}
							cffdb18d831d7f75053ca8b9f6bf2fc64.c30767ddca1f9c207888833aea5b5fc61(c667dd7d578392b64f2ae1cb91ee6686a.caffc9c8c53b2b4e64387e4898a3dd6f9, this.c3c897f76a0f75ab801de66894978eafa);
							goto IL_8E6;
						}
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
						}
					}
				}
				catch (Exception ex)
				{
					c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18672));
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00059E0C File Offset: 0x0005800C
		private void Mi4_Click(object sender, RoutedEventArgs e)
		{
			cbf4111912aed594f2b4372828dd95aa3.c8b3d85ac060012ebb4190ee9590fa377 c8b3d85ac060012ebb4190ee9590fa = new cbf4111912aed594f2b4372828dd95aa3.c8b3d85ac060012ebb4190ee9590fa377();
			c8b3d85ac060012ebb4190ee9590fa.cb6ea3d298d68be569f5410cc290458d5 = this;
			c8b3d85ac060012ebb4190ee9590fa.c97bb0419a7a851c991e9e986b8e0f5c1 = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c50727e34948ef9b15203539df949de95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Action(c8b3d85ac060012ebb4190ee9590fa.c35fbfa1af1abb8ce8817e0715494acc7)));
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00059E58 File Offset: 0x00058058
		private void AccList_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (cbe262a393cc86d89193ef06e195fa966.c30767ddca1f9c207888833aea5b5fc61(e) == MouseButton.Left)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_1C_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.AccList_MouseDown(object, MouseButtonEventArgs)).MethodHandle;
				}
				this.c5cb9b3ac544907604be054c2a4b2f785 = c7b821b89ee3ce02e1dc9ae56e4dfbf92.c30767ddca1f9c207888833aea5b5fc61(e, this.cd0054e6502658391b6115d5c0bbcdea7);
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00059E98 File Offset: 0x00058098
		public void c1a24697e9882c277735bd6b5e986e48b()
		{
			try
			{
				while (true)
				{
					IL_00:
					c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18676));
					if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_cab09f9e913dae41dc3e871fd28b3cdae())
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_32_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c1a24697e9882c277735bd6b5e986e48b()).MethodHandle;
						}
						IEnumerator<AccTreeViewInfo> enumerator = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b);
						try
						{
							while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
							{
								AccTreeViewInfo accTreeViewInfo = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator);
								if (!accTreeViewInfo.cc442622fc18861728248f70298b36dc7)
								{
									while (true)
									{
										switch (1)
										{
										case 0:
											continue;
										}
										break;
									}
									if (accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cab09f9e913dae41dc3e871fd28b3cdae)
									{
										while (true)
										{
											switch (2)
											{
											case 0:
												continue;
											}
											break;
										}
										bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18680) != 0;
										List<cc401045b2d3a107c5397ce08b50b21f0> list = this.ca363176affcc7719c87ca60ddb5f6f34.ce9dcf69fbd8c0e6fd7f4fa7272c0ceb7(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb5905b594e11dea2f73932df05981674);
										if (ca17defc9d21ff196f1b5a0e36a4a122c.c30767ddca1f9c207888833aea5b5fc61(list) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18684))
										{
											while (true)
											{
												switch (1)
												{
												case 0:
													continue;
												}
												break;
											}
											List<cc401045b2d3a107c5397ce08b50b21f0>.Enumerator enumerator2 = c73fdaeab2b6a0331a028ac6bb4a2d508.c30767ddca1f9c207888833aea5b5fc61(list);
											try
											{
												while (cb0f66325875ee6384ac8b6e8aeb6b47e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator2))
												{
													cc401045b2d3a107c5397ce08b50b21f0 cc401045b2d3a107c5397ce08b50b21f = cdb173ed9c4ca77e942a54eea75a79e28.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator2);
													DateTime dateTime = ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
													int num = c0b35616c82be2122817a6636f8c581a4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime) - (DayOfWeek)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18688);
													if (num == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18692))
													{
														while (true)
														{
															switch (7)
															{
															case 0:
																continue;
															}
															break;
														}
														num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18696);
													}
													TimeSpan timeSpan = c35ed2a6cd5aee97721789937d72dec8d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), new DateTime(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18700), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18704), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18708)));
													int num2 = (int)c14fc19292baa6b4d91081a23bba69961.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref timeSpan);
													if (cc401045b2d3a107c5397ce08b50b21f.c04f3a1ba94cd5bf5ae9908d00de8f369 > cc401045b2d3a107c5397ce08b50b21f.cda9f7f94b127e0b9c034e056d128a2a6)
													{
														while (true)
														{
															switch (4)
															{
															case 0:
																continue;
															}
															break;
														}
														TimeSpan timeSpan2 = c35ed2a6cd5aee97721789937d72dec8d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), new DateTime(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18712), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18716), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18720)));
														int num3 = (int)c658b04a9435c4c553d671979b19e1f9e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref timeSpan2);
														int num4 = num3 * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18724) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18728) + cc401045b2d3a107c5397ce08b50b21f.c04f3a1ba94cd5bf5ae9908d00de8f369;
														int num5 = num3 * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18732) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18736) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18740);
														int num6 = num3 * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18744) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18748) + cc401045b2d3a107c5397ce08b50b21f.cda9f7f94b127e0b9c034e056d128a2a6;
														int num7 = num3 * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18752) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18756);
														if (!cc401045b2d3a107c5397ce08b50b21f.c60c0eb2e26a4f9af0ed98ae796effea1)
														{
															continue;
														}
														while (true)
														{
															switch (4)
															{
															case 0:
																continue;
															}
															break;
														}
														if (cc401045b2d3a107c5397ce08b50b21f.c3ec335a884e0e805a58881f2832c8af0 != num)
														{
															while (true)
															{
																switch (3)
																{
																case 0:
																	continue;
																}
																break;
															}
															if (cc401045b2d3a107c5397ce08b50b21f.c3ec335a884e0e805a58881f2832c8af0 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18760))
															{
																continue;
															}
															while (true)
															{
																switch (4)
																{
																case 0:
																	continue;
																}
																break;
															}
														}
														if (num2 >= num7)
														{
															while (true)
															{
																switch (5)
																{
																case 0:
																	continue;
																}
																break;
															}
															if (num2 < num6)
															{
																goto IL_2C9;
															}
															while (true)
															{
																switch (7)
																{
																case 0:
																	continue;
																}
																break;
															}
														}
														if (num2 < num4)
														{
															continue;
														}
														while (true)
														{
															switch (7)
															{
															case 0:
																continue;
															}
															break;
														}
														if (num2 > num5)
														{
															continue;
														}
														while (true)
														{
															switch (1)
															{
															case 0:
																continue;
															}
															break;
														}
														IL_2C9:
														flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18764) != 0);
													}
													else
													{
														TimeSpan timeSpan3 = c35ed2a6cd5aee97721789937d72dec8d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), new DateTime(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18768), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18772), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18776)));
														int num8 = (int)c658b04a9435c4c553d671979b19e1f9e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref timeSpan3);
														TimeSpan timeSpan4 = c35ed2a6cd5aee97721789937d72dec8d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), new DateTime(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18780), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18784), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18788)));
														int num9 = (int)c658b04a9435c4c553d671979b19e1f9e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref timeSpan4);
														num8 = num8 * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18792) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18796) + cc401045b2d3a107c5397ce08b50b21f.c04f3a1ba94cd5bf5ae9908d00de8f369;
														num9 = num9 * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18800) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18804) + cc401045b2d3a107c5397ce08b50b21f.cda9f7f94b127e0b9c034e056d128a2a6;
														if (!cc401045b2d3a107c5397ce08b50b21f.c60c0eb2e26a4f9af0ed98ae796effea1)
														{
															continue;
														}
														while (true)
														{
															switch (7)
															{
															case 0:
																continue;
															}
															break;
														}
														if (cc401045b2d3a107c5397ce08b50b21f.c3ec335a884e0e805a58881f2832c8af0 != num)
														{
															while (true)
															{
																switch (5)
																{
																case 0:
																	continue;
																}
																break;
															}
															if (cc401045b2d3a107c5397ce08b50b21f.c3ec335a884e0e805a58881f2832c8af0 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18808))
															{
																continue;
															}
															while (true)
															{
																switch (7)
																{
																case 0:
																	continue;
																}
																break;
															}
														}
														if (num8 > num2)
														{
															continue;
														}
														while (true)
														{
															switch (1)
															{
															case 0:
																continue;
															}
															break;
														}
														if (num9 <= num2)
														{
															continue;
														}
														while (true)
														{
															switch (7)
															{
															case 0:
																continue;
															}
															break;
														}
														flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18812) != 0);
													}
													goto IL_430;
												}
												while (true)
												{
													switch (2)
													{
													case 0:
														continue;
													}
													break;
												}
											}
											finally
											{
												((IDisposable)enumerator2).Dispose();
											}
											IL_430:
											if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 == null)
											{
												while (true)
												{
													switch (1)
													{
													case 0:
														continue;
													}
													break;
												}
												if (flag)
												{
													while (true)
													{
														switch (4)
														{
														case 0:
															continue;
														}
														break;
													}
													accTreeViewInfo.cb04cbbfe07de8b466d30884575d54d48 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
													this.c27dd6fc0a36cf582997f24bf3bc5ff2e(accTreeViewInfo);
													if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c8932543d93a2768bd915e92e7b5ead3f() == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18816))
													{
														while (true)
														{
															switch (5)
															{
															case 0:
																continue;
															}
															break;
														}
														object expr_4A2 = AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(100516));
														string expr_4AE = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154513);
														int c3d585a6852405cf891cfcb4e3a = AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c3d585a6852405cf891cfcb4e3a687055();
														this.c8299fa31317d146976f1ea9cd623369b(cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(expr_4A2, expr_4AE, cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref c3d585a6852405cf891cfcb4e3a)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
														c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c3d585a6852405cf891cfcb4e3a687055() * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18820));
													}
													if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c8932543d93a2768bd915e92e7b5ead3f() == 0)
													{
														while (true)
														{
															switch (4)
															{
															case 0:
																continue;
															}
															break;
														}
														this.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(117537)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
														while (accTreeViewInfo != null)
														{
															while (true)
															{
																switch (7)
																{
																case 0:
																	continue;
																}
																break;
															}
															if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 == null)
															{
																break;
															}
															while (true)
															{
																switch (2)
																{
																case 0:
																	continue;
																}
																break;
															}
															if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.cadc48d65de68eec11ecdaaea06c3b51b)
															{
																while (true)
																{
																	switch (4)
																	{
																	case 0:
																		continue;
																	}
																	break;
																}
																break;
															}
															c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18824));
														}
														continue;
													}
													continue;
												}
											}
											if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 != null)
											{
												while (true)
												{
													switch (2)
													{
													case 0:
														continue;
													}
													break;
												}
												if (!flag)
												{
													while (true)
													{
														switch (7)
														{
														case 0:
															continue;
														}
														break;
													}
													accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.c5e071fc90b6534e9e9071f415f5b7deb();
												}
											}
										}
									}
								}
							}
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
							}
						}
					}
					IEnumerator<AccTreeViewInfo> enumerator3 = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b);
					try
					{
						IL_780:
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator3))
						{
							AccTreeViewInfo accTreeViewInfo2 = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator3);
							if (!accTreeViewInfo2.cc442622fc18861728248f70298b36dc7)
							{
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									break;
								}
								if (accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.ccb2c415213d47537af44476338eb3e7e)
								{
									while (true)
									{
										switch (3)
										{
										case 0:
											continue;
										}
										break;
									}
									if (accTreeViewInfo2.ca124a9f406cda69b904f2eb04d553ab9 == null)
									{
										while (true)
										{
											switch (2)
											{
											case 0:
												continue;
											}
											break;
										}
										accTreeViewInfo2.cb04cbbfe07de8b466d30884575d54d48 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
										this.c27dd6fc0a36cf582997f24bf3bc5ff2e(accTreeViewInfo2);
										if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c8932543d93a2768bd915e92e7b5ead3f() == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18828))
										{
											while (true)
											{
												switch (6)
												{
												case 0:
													continue;
												}
												break;
											}
											object expr_698 = AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(100516));
											string expr_6A4 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154513);
											int c3d585a6852405cf891cfcb4e3a2 = AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c3d585a6852405cf891cfcb4e3a687055();
											this.c8299fa31317d146976f1ea9cd623369b(cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(expr_698, expr_6A4, cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref c3d585a6852405cf891cfcb4e3a2)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
											c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c3d585a6852405cf891cfcb4e3a687055() * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18832));
										}
										if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c8932543d93a2768bd915e92e7b5ead3f() == 0)
										{
											while (true)
											{
												switch (2)
												{
												case 0:
													continue;
												}
												break;
											}
											this.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(117537)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
											while (accTreeViewInfo2 != null)
											{
												while (true)
												{
													switch (2)
													{
													case 0:
														continue;
													}
													break;
												}
												if (accTreeViewInfo2.ca124a9f406cda69b904f2eb04d553ab9 == null)
												{
													break;
												}
												while (true)
												{
													switch (6)
													{
													case 0:
														continue;
													}
													break;
												}
												if (accTreeViewInfo2.ca124a9f406cda69b904f2eb04d553ab9.cadc48d65de68eec11ecdaaea06c3b51b)
												{
													while (true)
													{
														switch (4)
														{
														case 0:
															continue;
														}
														goto IL_780;
													}
												}
												else
												{
													c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18836));
												}
											}
										}
									}
								}
							}
						}
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					finally
					{
						if (enumerator3 != null)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator3);
						}
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				goto IL_00;
			}
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0005A6D4 File Offset: 0x000588D4
		private void c87cf43c19dbc8576e89b476a3d5b5f07(ref string ptr, ref string ptr2, long num)
		{
			Socket socket = cfd8d6ed5f17bd7f35ffd8cc7a436e956.c0cf59c3e67a46fd4edb3040c5ab0bbfb((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18840), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18844), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18848));
			IPEndPoint iPEndPoint = c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c8356eb01945238ea2828cd429765eba8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c96816147ff4d2617d3c3ffe7abfc7353), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18852));
			c62eeeda7511b89b0e89a32f8bdb1a63c.c30767ddca1f9c207888833aea5b5fc61(socket, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18856) != 0);
			cbe9739bb0e6433d390ce8b139b40c99e.c30767ddca1f9c207888833aea5b5fc61(socket, iPEndPoint);
			cac6b8c3b1ea48900349fbec519fe3e12.c30767ddca1f9c207888833aea5b5fc61(socket, new ce671d8adbe4eaa5305f9d574101ee223(num).c442e09b1de2262d3a3a28826b3ea696f());
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18860));
			int num2 = c78a6935f0cfe67457f818f2c4181ea1b.c30767ddca1f9c207888833aea5b5fc61(socket, array);
			byte[] array2 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(num2);
			cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18864), array2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18868), num2);
			cde0ea7f5c550d7075b2d48f3b89e75cd cde0ea7f5c550d7075b2d48f3b89e75cd = new cde0ea7f5c550d7075b2d48f3b89e75cd(array2);
			ptr = cde0ea7f5c550d7075b2d48f3b89e75cd.c2ef6e95801b584dac1709dfdc2172cbc;
			ptr2 = cde0ea7f5c550d7075b2d48f3b89e75cd.c8be085255a937f1c23c56c93d755ff75;
			c4a69eb809830c0a7691e3f40cd2bff6d.c30767ddca1f9c207888833aea5b5fc61(socket);
			ceb80d96b00b2ecf9fc85cb2c934d4f00.c30767ddca1f9c207888833aea5b5fc61(socket);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0005A7BC File Offset: 0x000589BC
		private void ConfigToolStripButton_Click(object sender, RoutedEventArgs e)
		{
			if (!ccb3a37e39f5cb9245628b004349eac73.c30767ddca1f9c207888833aea5b5fc61(AppMain.c1a2627f895092b3cf57a9486ed72ee32))
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_20_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ConfigToolStripButton_Click(object, RoutedEventArgs)).MethodHandle;
				}
				cd42d36dd6f379099183ebe4983e29d89.c30767ddca1f9c207888833aea5b5fc61(AppMain.c1a2627f895092b3cf57a9486ed72ee32);
			}
			c87e60912a770e037fc3394d900687990.c30767ddca1f9c207888833aea5b5fc61(AppMain.c1a2627f895092b3cf57a9486ed72ee32);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0005A804 File Offset: 0x00058A04
		private void ce6c2e2a9c87da36d51d1e5342fd20ef8(ClientVersion clientVersion)
		{
			try
			{
				if ((int)clientVersion == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18872))
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_1F_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ce6c2e2a9c87da36d51d1e5342fd20ef8(ClientVersion)).MethodHandle;
					}
					if (c0ac73d3999671b2143416c98f97bdccc.c0cf59c3e67a46fd4edb3040c5ab0bbfb() == null)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						cbe96f9f6d9bbc586cc15ca8ad532c36c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c58406fbe44429c9e53d092923661637b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149101)), clientVersion));
						goto IL_B3;
					}
				}
				if ((int)clientVersion == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18876))
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					if (c6c9a49b4de52f27abc7f023798c627f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb() == null)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						c8807c32b71230516a28978149d6ed972.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c58406fbe44429c9e53d092923661637b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149125)), clientVersion));
					}
				}
				IL_B3:;
			}
			catch (Exception ex)
			{
				c2e5e290c5e34f024145fe136ad4da993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154518), ex));
				cdd6e82cc82d0907870bcea6f8d892056.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18880));
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0005A904 File Offset: 0x00058B04
		private void c27dd6fc0a36cf582997f24bf3bc5ff2e(AccTreeViewInfo cdc42dd0acc0401cea523023c11463c)
		{
			cbf4111912aed594f2b4372828dd95aa3.c42fc2c3d20f7176b8dfba4608d506523 c42fc2c3d20f7176b8dfba4608d = new cbf4111912aed594f2b4372828dd95aa3.c42fc2c3d20f7176b8dfba4608d506523();
			c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96 = cdc42dd0acc0401cea523023c11463c;
			c42fc2c3d20f7176b8dfba4608d.cb6ea3d298d68be569f5410cc290458d5 = this;
			if (c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96 == null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_32_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c27dd6fc0a36cf582997f24bf3bc5ff2e(AccTreeViewInfo)).MethodHandle;
				}
				return;
			}
			if (c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9 != null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			try
			{
				Action action = c2cffb0c8c347f2a1edaa1274b624dbd1.c8a754f5f2ca4adde825691a9c31a0e83;
				cbf4111912aed594f2b4372828dd95aa3.c9274186166aa974ae7c5bdefc671df92 c9274186166aa974ae7c5bdefc671df = new cbf4111912aed594f2b4372828dd95aa3.c9274186166aa974ae7c5bdefc671df92();
				c9274186166aa974ae7c5bdefc671df.c768dcb1024d7c851c6be8448d9e02a5a = c42fc2c3d20f7176b8dfba4608d;
				using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.c7d782871e24f979a312cdd1519df4097))
				{
					if (c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.cae1a1deccb5000499941ab0f2c99b1eb)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						return;
					}
					c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.cae1a1deccb5000499941ab0f2c99b1eb = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18884) != 0);
				}
				ushort cadb0be687ce11e2be1869999f35a = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18888);
				c9274186166aa974ae7c5bdefc671df.cf7f9dd41b0e6b39e2c5be23b31594c5c = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18892);
				c9274186166aa974ae7c5bdefc671df.c0e7f2605098a287d665d29e90ff19981 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18896);
				cd2f204b3667bc0717b94bda70a19099a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cdfd15fd9767ca3c899334e0591fc3b13, ref c9274186166aa974ae7c5bdefc671df.cf7f9dd41b0e6b39e2c5be23b31594c5c);
				if (!c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.c2a8aa71ce33e714c20c130e630219584)
				{
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					c9274186166aa974ae7c5bdefc671df.cf7f9dd41b0e6b39e2c5be23b31594c5c = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18900);
				}
				cd2f204b3667bc0717b94bda70a19099a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cdecfd55d76ff65b603e5b814c6504d6f, ref c9274186166aa974ae7c5bdefc671df.c0e7f2605098a287d665d29e90ff19981);
				cf4c18b862b5ab38a1922961ef9e01f17.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.c43acd5b8aee8aac3eb34d311d73db4b9, ref cadb0be687ce11e2be1869999f35a);
				c9274186166aa974ae7c5bdefc671df.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 = c20e605faeb6be84c3225b0c93d66bf04.c8a754f5f2ca4adde825691a9c31a0e83;
				c9274186166aa974ae7c5bdefc671df.c89ca75054b1fbd963984dc44a4afd9c0 = c8da62f54b736d40009f0d8f6e67bef11.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154565));
				if (c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.c805e30d018811e2793f3357a1dd68693)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					c9274186166aa974ae7c5bdefc671df.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 = new c9dc78792fcb683123688a66f4d248388();
					c9274186166aa974ae7c5bdefc671df.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b = c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cfb089fcc005d120966aebcd807c953eb;
					c9274186166aa974ae7c5bdefc671df.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141 = cadb0be687ce11e2be1869999f35a;
					c9274186166aa974ae7c5bdefc671df.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6 = c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.c19b1d008780db8f45326d62e4ae97cf1;
					c9274186166aa974ae7c5bdefc671df.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104 = c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.c5448fced558b14e475d62f73ac05a864;
				}
				if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, ""))
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.caee1e47a08a4ecec009fb2516f979104, ""))
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						this.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(97672))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
						if (action == null)
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							action = new Action(c9274186166aa974ae7c5bdefc671df.cc34013a2a94bbcde751e5e5cda155439);
						}
						Action action2 = action;
						cfcdf5ac55f9adba1a267019243e23146.c30767ddca1f9c207888833aea5b5fc61(action2);
					}
				}
			}
			finally
			{
				using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.c7d782871e24f979a312cdd1519df4097))
				{
					c42fc2c3d20f7176b8dfba4608d.cdc42dd0acc0401cea523023c11463c96.cae1a1deccb5000499941ab0f2c99b1eb = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18904) != 0);
				}
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0005AC78 File Offset: 0x00058E78
		private void AccList_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
		{
			try
			{
				if (c66bf6a272b147c49a23cb722a4ad1251.c30767ddca1f9c207888833aea5b5fc61(e) == (MouseButtonState)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18908))
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_29_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.AccList_MouseMove(object, System.Windows.Input.MouseEventArgs)).MethodHandle;
					}
					System.Windows.Point point = c7b821b89ee3ce02e1dc9ae56e4dfbf92.c30767ddca1f9c207888833aea5b5fc61(e, this.cd0054e6502658391b6115d5c0bbcdea7);
					if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) != null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) != null)
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c325e71c0324cd2fc7e4ace4c554061e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c600f43d07cccd3d3e2cbc3165715b159.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point) - c600f43d07cccd3d3e2cbc3165715b159.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c5cb9b3ac544907604be054c2a4b2f785)) <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(18912))
							{
								while (true)
								{
									switch (6)
									{
									case 0:
										continue;
									}
									break;
								}
								if (c325e71c0324cd2fc7e4ace4c554061e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c1d47e3dab642c616a250deae2df2cd6f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point) - c1d47e3dab642c616a250deae2df2cd6f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c5cb9b3ac544907604be054c2a4b2f785)) <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(18920))
								{
									goto IL_4AC;
								}
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
							}
							TreeViewItem treeViewItem = this.c5f7d068efde4f72bf6ffac104defa66d(c752ce6b9a2fd47440c23d2dfca1fbda9.cea69e7c4d1a729bd5783221de1566e79(c5091c3a115c5df51c75a67887ef1b8d6.c30767ddca1f9c207888833aea5b5fc61(e)));
							this.ccfcabad6787ff6760a732cf8c31045ff = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
							if (this.ccfcabad6787ff6760a732cf8c31045ff != null)
							{
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									break;
								}
								if (treeViewItem != null)
								{
									while (true)
									{
										switch (6)
										{
										case 0:
											continue;
										}
										break;
									}
									if (treeViewItem != null)
									{
										while (true)
										{
											switch (7)
											{
											case 0:
												continue;
											}
											break;
										}
										if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c0a45cc948868ba6185f93c52b725dd87.c30767ddca1f9c207888833aea5b5fc61(treeViewItem)) != null)
										{
											while (true)
											{
												switch (4)
												{
												case 0:
													continue;
												}
												break;
											}
											if (this.ccfcabad6787ff6760a732cf8c31045ff == cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c0a45cc948868ba6185f93c52b725dd87.c30767ddca1f9c207888833aea5b5fc61(treeViewItem)))
											{
												while (true)
												{
													switch (2)
													{
													case 0:
														continue;
													}
													break;
												}
												System.Windows.DragDropEffects dragDropEffects = c4e90d8c97dd3d58c74e3cfa4412fea97.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cd0054e6502658391b6115d5c0bbcdea7, c05ed75de7973140ea2a8edde4aad2297.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7), (System.Windows.DragDropEffects)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18928));
												if (dragDropEffects == (System.Windows.DragDropEffects)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18932))
												{
													while (true)
													{
														switch (1)
														{
														case 0:
															continue;
														}
														break;
													}
													if (this.c08f8a3c6f01bd44442b9cbfc43c9459a != null)
													{
														while (true)
														{
															switch (5)
															{
															case 0:
																continue;
															}
															break;
														}
														if (this.c08f8a3c6f01bd44442b9cbfc43c9459a.cb5905b594e11dea2f73932df05981674 != 0)
														{
															while (true)
															{
																switch (2)
																{
																case 0:
																	continue;
																}
																break;
															}
															this.c7b27194d7b60931174f4e188c6dc1810(this.ccfcabad6787ff6760a732cf8c31045ff, this.c08f8a3c6f01bd44442b9cbfc43c9459a);
															for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18936); i < cc726b93578a46114675f92592d04942f.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18976))
															{
																for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18940); j < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(ceaa62c091f06923c8723464b639899db.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, i))); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18972))
																{
																	if (c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(ceaa62c091f06923c8723464b639899db.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, i)), j) == this.c08f8a3c6f01bd44442b9cbfc43c9459a)
																	{
																		while (true)
																		{
																			switch (7)
																			{
																			case 0:
																				continue;
																			}
																			break;
																		}
																		this.ccfcabad6787ff6760a732cf8c31045ff.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4 = cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(cbb05cfd45ebd1453ef86502b79dbb73d.c30767ddca1f9c207888833aea5b5fc61(ceaa62c091f06923c8723464b639899db.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, i)));
																		this.ccfcabad6787ff6760a732cf8c31045ff.ce1ed6a6cb7304463ffd824d14b62f430.cdfd15fd9767ca3c899334e0591fc3b13 = c4fb5da867a6dcef965e83d2e660c0364.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(ceaa62c091f06923c8723464b639899db.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e, i)), j).cb5905b594e11dea2f73932df05981674);
																		bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18944) != 0;
																		try
																		{
																			object cdb456cfdfb988429e8ab93cb585f031e;
																			cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = this.ccfcabad6787ff6760a732cf8c31045ff.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
																			this.ccfcabad6787ff6760a732cf8c31045ff.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18948) != 0);
																		}
																		finally
																		{
																			if (flag)
																			{
																				while (true)
																				{
																					switch (6)
																					{
																					case 0:
																						continue;
																					}
																					break;
																				}
																				object cdb456cfdfb988429e8ab93cb585f031e;
																				c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
																			}
																		}
																		int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18952);
																		c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ccfcabad6787ff6760a732cf8c31045ff.ce1ed6a6cb7304463ffd824d14b62f430.cdfd15fd9767ca3c899334e0591fc3b13, ref num);
																		if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ccfcabad6787ff6760a732cf8c31045ff.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153667)))
																		{
																			while (true)
																			{
																				switch (1)
																				{
																				case 0:
																					continue;
																				}
																				break;
																			}
																			c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18956));
																		}
																		else if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ccfcabad6787ff6760a732cf8c31045ff.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153680)))
																		{
																			while (true)
																			{
																				switch (7)
																				{
																				case 0:
																					continue;
																				}
																				break;
																			}
																			c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18960));
																		}
																		else if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ccfcabad6787ff6760a732cf8c31045ff.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153707)))
																		{
																			while (true)
																			{
																				switch (2)
																				{
																				case 0:
																					continue;
																				}
																				break;
																			}
																			c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18964));
																		}
																		else
																		{
																			c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18968));
																		}
																		this.ce81442b3fa99d1ee563985966d316333(num);
																	}
																}
																while (true)
																{
																	switch (6)
																	{
																	case 0:
																		continue;
																	}
																	break;
																}
															}
															while (true)
															{
																switch (3)
																{
																case 0:
																	continue;
																}
																break;
															}
															this.c08f8a3c6f01bd44442b9cbfc43c9459a = c2733fee0206336a7fb39d68bc0ae5507.c8a754f5f2ca4adde825691a9c31a0e83;
															this.ccfcabad6787ff6760a732cf8c31045ff = c2aa93f14f02daf7434a6dc4f4f6c363a.c8a754f5f2ca4adde825691a9c31a0e83;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_4AC:;
			}
			catch (Exception ex)
			{
				c8761875271fc238365016dcd30db760f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0005B17C File Offset: 0x0005937C
		private void AccList_Drop(object sender, System.Windows.DragEventArgs e)
		{
			try
			{
				caca7c2b4f3e10e15d11785d87812683a.c30767ddca1f9c207888833aea5b5fc61(e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18980) != 0);
				this.c08f8a3c6f01bd44442b9cbfc43c9459a = this.ca4c32c3ff8244011a9239e46ccb131d3(c752ce6b9a2fd47440c23d2dfca1fbda9.cea69e7c4d1a729bd5783221de1566e79(c5091c3a115c5df51c75a67887ef1b8d6.c30767ddca1f9c207888833aea5b5fc61(e)));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0005B1CC File Offset: 0x000593CC
		private void AccList_DragOver(object sender, System.Windows.DragEventArgs e)
		{
			try
			{
				c22c0572ca0e3d35473727906fa518cbe.c30767ddca1f9c207888833aea5b5fc61(e, (System.Windows.DragDropEffects)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18984));
				System.Windows.Point point = c3a09aed789564ccae90ce2e68cd74e64.c30767ddca1f9c207888833aea5b5fc61(e, this.cd0054e6502658391b6115d5c0bbcdea7);
				if (c325e71c0324cd2fc7e4ace4c554061e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c600f43d07cccd3d3e2cbc3165715b159.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point) - c600f43d07cccd3d3e2cbc3165715b159.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c5cb9b3ac544907604be054c2a4b2f785)) <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(18988))
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_5D_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.AccList_DragOver(object, System.Windows.DragEventArgs)).MethodHandle;
					}
					if (c325e71c0324cd2fc7e4ace4c554061e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c1d47e3dab642c616a250deae2df2cd6f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point) - c1d47e3dab642c616a250deae2df2cd6f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c5cb9b3ac544907604be054c2a4b2f785)) <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(18996))
					{
						goto IL_ED;
					}
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				ServerTreeViewInfo serverTreeViewInfo = this.ca4c32c3ff8244011a9239e46ccb131d3(c752ce6b9a2fd47440c23d2dfca1fbda9.cea69e7c4d1a729bd5783221de1566e79(c5091c3a115c5df51c75a67887ef1b8d6.c30767ddca1f9c207888833aea5b5fc61(e)));
				if (serverTreeViewInfo != null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					if (serverTreeViewInfo.cb5905b594e11dea2f73932df05981674 != 0)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						c22c0572ca0e3d35473727906fa518cbe.c30767ddca1f9c207888833aea5b5fc61(e, (System.Windows.DragDropEffects)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19004));
						goto IL_ED;
					}
				}
				c22c0572ca0e3d35473727906fa518cbe.c30767ddca1f9c207888833aea5b5fc61(e, (System.Windows.DragDropEffects)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19008));
				IL_ED:
				caca7c2b4f3e10e15d11785d87812683a.c30767ddca1f9c207888833aea5b5fc61(e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19012) != 0);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0005B2EC File Offset: 0x000594EC
		private A c7cb14ecf42ff93ff27b34e69b5e250ec<A>(DependencyObject dependencyObject) where A : DependencyObject
		{
			DependencyObject dependencyObject2 = cd215bf7f948ab89e9131c53379901862.c0cf59c3e67a46fd4edb3040c5ab0bbfb(dependencyObject);
			if (dependencyObject2 == null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_1E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c7cb14ecf42ff93ff27b34e69b5e250ec(DependencyObject)).MethodHandle;
				}
				return default(A);
			}
			A a = dependencyObject2 as A;
			if (a != null)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				return a;
			}
			return this.c7cb14ecf42ff93ff27b34e69b5e250ec<A>(dependencyObject2);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0005B34C File Offset: 0x0005954C
		private static A c7cb14ecf42ff93ff27b34e69b5e250ec<A>(UIElement uIElement) where A : UIElement
		{
			if (uIElement == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_15_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c7cb14ecf42ff93ff27b34e69b5e250ec(UIElement)).MethodHandle;
				}
				return default(A);
			}
			for (UIElement uIElement2 = c752ce6b9a2fd47440c23d2dfca1fbda9.cea69e7c4d1a729bd5783221de1566e79(cd215bf7f948ab89e9131c53379901862.c0cf59c3e67a46fd4edb3040c5ab0bbfb(uIElement)); uIElement2 != null; uIElement2 = c752ce6b9a2fd47440c23d2dfca1fbda9.cea69e7c4d1a729bd5783221de1566e79(cd215bf7f948ab89e9131c53379901862.c0cf59c3e67a46fd4edb3040c5ab0bbfb(uIElement2)))
			{
				A a = uIElement2 as A;
				if (a != null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					return a;
				}
			}
			while (true)
			{
				switch (4)
				{
				case 0:
					continue;
				}
				break;
			}
			return default(A);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0005B3D4 File Offset: 0x000595D4
		private ServerTreeViewInfo ca4c32c3ff8244011a9239e46ccb131d3(UIElement uIElement)
		{
			TreeViewItem treeViewItem = c274e44e167d08d0d3dfa42dda0d4bd62.cea69e7c4d1a729bd5783221de1566e79(uIElement);
			ServerTreeViewInfo serverTreeViewInfo = c2733fee0206336a7fb39d68bc0ae5507.c8a754f5f2ca4adde825691a9c31a0e83;
			while (serverTreeViewInfo == null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (treeViewItem != null)
				{
					break;
				}
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (uIElement == null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						return serverTreeViewInfo;
					}
				}
				else
				{
					uIElement = c752ce6b9a2fd47440c23d2dfca1fbda9.cea69e7c4d1a729bd5783221de1566e79(cd215bf7f948ab89e9131c53379901862.c0cf59c3e67a46fd4edb3040c5ab0bbfb(uIElement));
					treeViewItem = c274e44e167d08d0d3dfa42dda0d4bd62.cea69e7c4d1a729bd5783221de1566e79(uIElement);
					if (treeViewItem != null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_42_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ca4c32c3ff8244011a9239e46ccb131d3(UIElement)).MethodHandle;
						}
						serverTreeViewInfo = cc272f7f9b9c40a31ad01733e88382568.cea69e7c4d1a729bd5783221de1566e79(c0a45cc948868ba6185f93c52b725dd87.c30767ddca1f9c207888833aea5b5fc61(treeViewItem));
					}
				}
			}
			return serverTreeViewInfo;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0005B45C File Offset: 0x0005965C
		private TreeViewItem c5f7d068efde4f72bf6ffac104defa66d(UIElement uIElement)
		{
			TreeViewItem treeViewItem = c274e44e167d08d0d3dfa42dda0d4bd62.cea69e7c4d1a729bd5783221de1566e79(uIElement);
			while (treeViewItem == null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_3C_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c5f7d068efde4f72bf6ffac104defa66d(UIElement)).MethodHandle;
				}
				if (uIElement == null)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						return treeViewItem;
					}
				}
				else
				{
					uIElement = c752ce6b9a2fd47440c23d2dfca1fbda9.cea69e7c4d1a729bd5783221de1566e79(cd215bf7f948ab89e9131c53379901862.c0cf59c3e67a46fd4edb3040c5ab0bbfb(uIElement));
					treeViewItem = c274e44e167d08d0d3dfa42dda0d4bd62.cea69e7c4d1a729bd5783221de1566e79(uIElement);
				}
			}
			return treeViewItem;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0005B4B4 File Offset: 0x000596B4
		private void c7b27194d7b60931174f4e188c6dc1810(AccTreeViewInfo accTreeViewInfo, ServerTreeViewInfo serverTreeViewInfo)
		{
			if (accTreeViewInfo != null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_15_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c7b27194d7b60931174f4e188c6dc1810(AccTreeViewInfo, ServerTreeViewInfo)).MethodHandle;
				}
				if (serverTreeViewInfo != null)
				{
					try
					{
						ServerTreeViewInfo serverTreeViewInfo2 = c2733fee0206336a7fb39d68bc0ae5507.c8a754f5f2ca4adde825691a9c31a0e83;
						IEnumerator<WorldTreeViewInfo> enumerator = c64aaef4a72b1cca6cf3b8e689c30656c.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e);
						try
						{
							IL_B2:
							while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
							{
								WorldTreeViewInfo worldTreeViewInfo = c6cb3068dd1dba97b102455710cf6a79f.c30767ddca1f9c207888833aea5b5fc61(enumerator);
								IEnumerator<ServerTreeViewInfo> enumerator2 = c266116c92138d153032ef71f5e63e4fc.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(worldTreeViewInfo));
								try
								{
									while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator2))
									{
										ServerTreeViewInfo serverTreeViewInfo3 = c6ab76f0df3a33e553b2cfe7c47b9f13b.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
										if (c5d612b6af237105ace49cebd0c86f9ce.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo3), accTreeViewInfo))
										{
											while (true)
											{
												switch (5)
												{
												case 0:
													continue;
												}
												break;
											}
											serverTreeViewInfo2 = serverTreeViewInfo3;
											goto IL_B2;
										}
									}
									while (true)
									{
										switch (2)
										{
										case 0:
											continue;
										}
										break;
									}
								}
								finally
								{
									if (enumerator2 != null)
									{
										while (true)
										{
											switch (5)
											{
											case 0:
												continue;
											}
											break;
										}
										cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
									}
								}
							}
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									break;
								}
								cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
							}
						}
						if (serverTreeViewInfo2 != null)
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							if (serverTreeViewInfo2 != serverTreeViewInfo)
							{
								while (true)
								{
									switch (6)
									{
									case 0:
										continue;
									}
									break;
								}
								c3118a9e6b2e6153bc5661d815a17e763.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo2), accTreeViewInfo);
								cbda07944d81d960558721b7a09c651ae.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo), accTreeViewInfo);
								this.cac383f9c4c18ddf9fcd22b48958556c9();
							}
						}
					}
					catch (Exception ex)
					{
						c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
					}
					return;
				}
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0005B644 File Offset: 0x00059844
		private void accList_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
		{
			if (c9e32aa1190f5bc969e61888b08693352.c30767ddca1f9c207888833aea5b5fc61(e) != null)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_1F_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.accList_SelectedItemChanged(object, RoutedPropertyChangedEventArgs<object>)).MethodHandle;
				}
				if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c9e32aa1190f5bc969e61888b08693352.c30767ddca1f9c207888833aea5b5fc61(e)) != null)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c9e32aa1190f5bc969e61888b08693352.c30767ddca1f9c207888833aea5b5fc61(e));
					int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19016);
					int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19020);
					c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cdecfd55d76ff65b603e5b814c6504d6f, ref num);
					c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cdfd15fd9767ca3c899334e0591fc3b13, ref num2);
					if (num >= cba94ff567d7675d5b882c293b1f8f4e1.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c82ec624b8aadfbc9191641f0732a0585)))
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						num = cba94ff567d7675d5b882c293b1f8f4e1.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c82ec624b8aadfbc9191641f0732a0585)) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19024);
					}
					cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.c9f561fbdac0b087661c3d93674314c66, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.ca56117bd7a22712111d34d4bd3aa8642);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c9f561fbdac0b087661c3d93674314c66, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19028) != 0);
					cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.cb5466a044809fda944eb67b4c5d2c8f6, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.cb5466a044809fda944eb67b4c5d2c8f6, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19032) != 0);
					cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.caee1e47a08a4ecec009fb2516f979104, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.caee1e47a08a4ecec009fb2516f979104);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.caee1e47a08a4ecec009fb2516f979104, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19036) != 0);
					c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c82ec624b8aadfbc9191641f0732a0585, num);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c82ec624b8aadfbc9191641f0732a0585, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19040) != 0);
					c318fb189283ebe3b3d5d5558814fe2e3.c30767ddca1f9c207888833aea5b5fc61(this.c5307093aef47df1751709d07538b52be, new bool?(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c2a8aa71ce33e714c20c130e630219584));
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c5307093aef47df1751709d07538b52be, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19044) != 0);
					c318fb189283ebe3b3d5d5558814fe2e3.c30767ddca1f9c207888833aea5b5fc61(this.c4953d61ea34c200d1a6de0f69c4a68a0, new bool?(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.ccb2c415213d47537af44476338eb3e7e));
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c4953d61ea34c200d1a6de0f69c4a68a0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19048) != 0);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19052) != 0);
					if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153667)))
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19056));
					}
					else if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153680)))
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19060));
					}
					else if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153707)))
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19064));
					}
					else
					{
						c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19068));
					}
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19072) != 0);
					this.ce81442b3fa99d1ee563985966d316333(num2);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c32d431e171445fedfa242784a5820a56, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19076) != 0);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.cccf7b701d7e8c96a5b5661ceffff1174, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19080) != 0);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c0b0afb159eaf61457df227310912e74e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19084) != 0);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c661edb793c0ae9dd33ed1849ba92660b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19088) != 0);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19092) != 0);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c8d495e9cc44c58f78c66024676ad9a57, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19096) != 0);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c137952fe128ebb66ae21d036d05ec47c, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19100) != 0);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c8df21b00eff0ed569413a87a911e5013, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19104) != 0);
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19108) != 0);
					this.c5137cf89d9148f17cc4ecfe0744db567(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb5905b594e11dea2f73932df05981674);
					c318fb189283ebe3b3d5d5558814fe2e3.c30767ddca1f9c207888833aea5b5fc61(this.c8df21b00eff0ed569413a87a911e5013, new bool?(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cab09f9e913dae41dc3e871fd28b3cdae));
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c0b6b42203c605a20b7c59af22954e91b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19112) != 0);
					object arg_45E_0 = this.c3f8ccec3c9716cc1310498718b64ea5e;
					object[] array = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19116));
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19120)] = accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c5b1995a63fedd9443b419598ca3ea08f;
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19124)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151025);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19128)] = accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cab75189cbbf8f77be131afc306254891;
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19132)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154634);
					c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(arg_45E_0, c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array));
					c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c58344346cb86ff408ae0809ed6c973c3, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c084849f9701722a8a82ccb51e3567e62);
					object arg_4B4_0 = this.c12a7ad156cb9ad1cf39a52d76e06acb5;
					double num3 = (double)accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cca5ded226e650778b7fe76464af7cdcd / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(19136);
					c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(arg_4B4_0, cd26c1ed86899b91c17e61188444ccd80.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151020)));
					c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c647d1308c87f5348cfe144e6821c97b2, this.cccd5cbc3d8eb61a5107082cf91ebdbeb(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c4059fe7fb67522e038fb94baf8150674));
					c318fb189283ebe3b3d5d5558814fe2e3.c30767ddca1f9c207888833aea5b5fc61(this.cd9d6c8eccb641592989df004f1e1c45f, new bool?(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c805e30d018811e2793f3357a1dd68693));
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.cd9d6c8eccb641592989df004f1e1c45f, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19144) != 0);
					cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.cfb089fcc005d120966aebcd807c953eb, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfb089fcc005d120966aebcd807c953eb);
					cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.c19b1d008780db8f45326d62e4ae97cf1, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c19b1d008780db8f45326d62e4ae97cf1);
					cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.c5448fced558b14e475d62f73ac05a864, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c5448fced558b14e475d62f73ac05a864);
					cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.c43acd5b8aee8aac3eb34d311d73db4b9, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c43acd5b8aee8aac3eb34d311d73db4b9);
					if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb985061242b7c893cd2fde331e41a62a, ""))
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						c29c9e2e3faaeaa8f38c43a85bf39d6d3.c30767ddca1f9c207888833aea5b5fc61(this.c9870c914e51fdff3e46125bc50d1f172, c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
					}
					else
					{
						c42efaf6735ad07131f3c1d5bbeca6fdf.c30767ddca1f9c207888833aea5b5fc61(this.c9870c914e51fdff3e46125bc50d1f172, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb985061242b7c893cd2fde331e41a62a);
					}
					if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4a00b99a91cd60e4dd1da1f86c4fd5a5.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153667)))
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4a00b99a91cd60e4dd1da1f86c4fd5a5.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153680)))
						{
							c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c9870c914e51fdff3e46125bc50d1f172, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19152) != 0);
							goto IL_62E;
						}
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c9870c914e51fdff3e46125bc50d1f172, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19148) != 0);
					IL_62E:
					cce9c6970ae3314a1c0a269eb03d3cfa1.c30767ddca1f9c207888833aea5b5fc61(this.c155f664c997c9a5d6c158781375a2796, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154647));
					cce9c6970ae3314a1c0a269eb03d3cfa1.c30767ddca1f9c207888833aea5b5fc61(this.c86691c3d7259507eaad34cf7705ae6fd, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154664));
					cce9c6970ae3314a1c0a269eb03d3cfa1.c30767ddca1f9c207888833aea5b5fc61(this.c13885786862bdc36510c4781ec731c97, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154683));
					ca4daea125977084cd45411b7e5e9d12a.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					AppMain.cdd1757f475d38dea2e5af9e3fac6be8c.c224a9900be1d00ee16e2feeab0dbba1c();
					this.c868c67d6fc0d52fc8a7700bde517c483(accTreeViewInfo, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19156) != 0);
					return;
				}
				cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.c9f561fbdac0b087661c3d93674314c66, "");
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c9f561fbdac0b087661c3d93674314c66, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19160) != 0);
				cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.cb5466a044809fda944eb67b4c5d2c8f6, "");
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.cb5466a044809fda944eb67b4c5d2c8f6, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19164) != 0);
				cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.caee1e47a08a4ecec009fb2516f979104, "");
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.caee1e47a08a4ecec009fb2516f979104, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19168) != 0);
				c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c82ec624b8aadfbc9191641f0732a0585, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19172));
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c82ec624b8aadfbc9191641f0732a0585, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19176) != 0);
				c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19180));
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19184) != 0);
				c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19188));
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19192) != 0);
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19196) != 0);
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c32d431e171445fedfa242784a5820a56, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19200) != 0);
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.cccf7b701d7e8c96a5b5661ceffff1174, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19204) != 0);
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c0b0afb159eaf61457df227310912e74e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19208) != 0);
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c661edb793c0ae9dd33ed1849ba92660b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19212) != 0);
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19216) != 0);
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c8d495e9cc44c58f78c66024676ad9a57, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19220) != 0);
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c137952fe128ebb66ae21d036d05ec47c, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19224) != 0);
				cbfa19a62943d23dc53ac73bcaa2e7ca4.c30767ddca1f9c207888833aea5b5fc61(cceb8b6cda797b5d3dd47c135717cf0a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c8df21b00eff0ed569413a87a911e5013, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19228) != 0);
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c0b6b42203c605a20b7c59af22954e91b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19232) != 0);
				c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c3f8ccec3c9716cc1310498718b64ea5e, "");
				c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c58344346cb86ff408ae0809ed6c973c3, "");
				c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c12a7ad156cb9ad1cf39a52d76e06acb5, "");
				c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.c647d1308c87f5348cfe144e6821c97b2, "");
				c318fb189283ebe3b3d5d5558814fe2e3.c30767ddca1f9c207888833aea5b5fc61(this.c5307093aef47df1751709d07538b52be, new bool?(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19236) != 0));
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c5307093aef47df1751709d07538b52be, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19240) != 0);
				c318fb189283ebe3b3d5d5558814fe2e3.c30767ddca1f9c207888833aea5b5fc61(this.c4953d61ea34c200d1a6de0f69c4a68a0, new bool?(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19244) != 0));
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c4953d61ea34c200d1a6de0f69c4a68a0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19248) != 0);
				c318fb189283ebe3b3d5d5558814fe2e3.c30767ddca1f9c207888833aea5b5fc61(this.cd9d6c8eccb641592989df004f1e1c45f, new bool?(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19252) != 0));
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.cd9d6c8eccb641592989df004f1e1c45f, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19256) != 0);
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.cefce72c9f3171228780df28ff61afccb, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19260) != 0);
				cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.cfb089fcc005d120966aebcd807c953eb, "");
				cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.c19b1d008780db8f45326d62e4ae97cf1, "");
				cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.c5448fced558b14e475d62f73ac05a864, "");
				cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.c43acd5b8aee8aac3eb34d311d73db4b9, "");
				ca4daea125977084cd45411b7e5e9d12a.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				cce9c6970ae3314a1c0a269eb03d3cfa1.c30767ddca1f9c207888833aea5b5fc61(this.c155f664c997c9a5d6c158781375a2796, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154647));
				cce9c6970ae3314a1c0a269eb03d3cfa1.c30767ddca1f9c207888833aea5b5fc61(this.c86691c3d7259507eaad34cf7705ae6fd, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154664));
				cce9c6970ae3314a1c0a269eb03d3cfa1.c30767ddca1f9c207888833aea5b5fc61(this.c13885786862bdc36510c4781ec731c97, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154683));
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0005C030 File Offset: 0x0005A230
		private void accList_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
		{
			try
			{
				TreeViewItem treeViewItem = this.c5f7d068efde4f72bf6ffac104defa66d(c752ce6b9a2fd47440c23d2dfca1fbda9.cea69e7c4d1a729bd5783221de1566e79(c5091c3a115c5df51c75a67887ef1b8d6.c30767ddca1f9c207888833aea5b5fc61(e)));
				if (treeViewItem != null)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_30_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.accList_MouseRightButtonDown(object, MouseButtonEventArgs)).MethodHandle;
					}
					c50f016c3da50f8713e241c231dc5b6d9.c30767ddca1f9c207888833aea5b5fc61(treeViewItem);
					cc5bad39226b9e6eeb38d63acd5265aaa.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, this.cde612ef6cd46010d5aa48e8da32c8dd1);
					c8e11527ccaa837133ed7e12e0173a106.c30767ddca1f9c207888833aea5b5fc61(cd93be8da7787cff72460ccd86d75c42f.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7), treeViewItem);
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19264); i < cba94ff567d7675d5b882c293b1f8f4e1.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(cd93be8da7787cff72460ccd86d75c42f.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7))); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19272))
					{
						System.Windows.Controls.MenuItem menuItem = c2fa02ae23f61a7b76d18a404fd13bc9d.cea69e7c4d1a729bd5783221de1566e79(c3980231756d98f77b332e12a7eea1cf0.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(cd93be8da7787cff72460ccd86d75c42f.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)), i));
						if (menuItem != null)
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
							c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(menuItem, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19268) != 0);
						}
					}
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c0a45cc948868ba6185f93c52b725dd87.c30767ddca1f9c207888833aea5b5fc61(treeViewItem)) != null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c0a45cc948868ba6185f93c52b725dd87.c30767ddca1f9c207888833aea5b5fc61(treeViewItem));
						if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 == null)
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(c2fa02ae23f61a7b76d18a404fd13bc9d.cea69e7c4d1a729bd5783221de1566e79(c3980231756d98f77b332e12a7eea1cf0.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(cd93be8da7787cff72460ccd86d75c42f.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19276))), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19280) != 0);
							c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(c2fa02ae23f61a7b76d18a404fd13bc9d.cea69e7c4d1a729bd5783221de1566e79(c3980231756d98f77b332e12a7eea1cf0.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(cd93be8da7787cff72460ccd86d75c42f.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19284))), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19288) != 0);
						}
						if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 != null)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(c2fa02ae23f61a7b76d18a404fd13bc9d.cea69e7c4d1a729bd5783221de1566e79(c3980231756d98f77b332e12a7eea1cf0.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(cd93be8da7787cff72460ccd86d75c42f.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19292))), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19296) != 0);
						}
					}
					if (cc272f7f9b9c40a31ad01733e88382568.cea69e7c4d1a729bd5783221de1566e79(c0a45cc948868ba6185f93c52b725dd87.c30767ddca1f9c207888833aea5b5fc61(treeViewItem)) != null)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(c2fa02ae23f61a7b76d18a404fd13bc9d.cea69e7c4d1a729bd5783221de1566e79(c3980231756d98f77b332e12a7eea1cf0.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(cd93be8da7787cff72460ccd86d75c42f.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19300))), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19304) != 0);
					}
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0005C2AC File Offset: 0x0005A4AC
		private void gameWorld_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Func<ServerTreeViewInfo, bool> func = c7587aaefdaf8775287a710bc42882968.c8a754f5f2ca4adde825691a9c31a0e83;
			Func<ServerTreeViewInfo, bool> func2 = c7587aaefdaf8775287a710bc42882968.c8a754f5f2ca4adde825691a9c31a0e83;
			Func<ServerTreeViewInfo, bool> func3 = c7587aaefdaf8775287a710bc42882968.c8a754f5f2ca4adde825691a9c31a0e83;
			cbf4111912aed594f2b4372828dd95aa3.c7a3df66530e3730db75913af5d98b71c c7a3df66530e3730db75913af5d98b71c = new cbf4111912aed594f2b4372828dd95aa3.c7a3df66530e3730db75913af5d98b71c();
			c7a3df66530e3730db75913af5d98b71c.cbbeb35f186b790f432ceeaae457dfa3e = e;
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_45_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.gameWorld_SelectionChanged(object, SelectionChangedEventArgs)).MethodHandle;
				}
				return;
			}
			if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(cc5ba717e158effd00e766e2a1f120307.cea69e7c4d1a729bd5783221de1566e79(sender)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19308))
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19312))
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				IEnumerable<ServerTreeViewInfo> arg_EB_0 = this.c2d1e187c9efce20e55655d518436259c;
				if (func == null)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					func = new Func<ServerTreeViewInfo, bool>(c7a3df66530e3730db75913af5d98b71c.c0265fb29c22d9b4ec3ae9deb68ead851);
				}
				ServerTreeViewInfo serverTreeViewInfo = arg_EB_0.FirstOrDefault(func);
				if (serverTreeViewInfo != null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cdfd15fd9767ca3c899334e0591fc3b13 = c4fb5da867a6dcef965e83d2e660c0364.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref serverTreeViewInfo.cb5905b594e11dea2f73932df05981674);
					this.c7b27194d7b60931174f4e188c6dc1810(accTreeViewInfo, serverTreeViewInfo);
					c9ed445f5332926a0c8d022c6e9fda720.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19316) != 0);
				}
			}
			if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19320))
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				IEnumerable<ServerTreeViewInfo> arg_178_0 = this.cd9db19395aea8d58426dab9ecf93bb34;
				if (func2 == null)
				{
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					func2 = new Func<ServerTreeViewInfo, bool>(c7a3df66530e3730db75913af5d98b71c.c98e181ea738108b77513188ef263e949);
				}
				ServerTreeViewInfo serverTreeViewInfo2 = arg_178_0.FirstOrDefault(func2);
				if (serverTreeViewInfo2 != null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cdfd15fd9767ca3c899334e0591fc3b13 = c4fb5da867a6dcef965e83d2e660c0364.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref serverTreeViewInfo2.cb5905b594e11dea2f73932df05981674);
					this.c7b27194d7b60931174f4e188c6dc1810(accTreeViewInfo, serverTreeViewInfo2);
					c9ed445f5332926a0c8d022c6e9fda720.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19324) != 0);
				}
			}
			if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19328))
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				IEnumerable<ServerTreeViewInfo> arg_205_0 = this.c211a8cb0fd0860bc469ed8ef20980300;
				if (func3 == null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					func3 = new Func<ServerTreeViewInfo, bool>(c7a3df66530e3730db75913af5d98b71c.c822f3916ffa256f94e2eaedb3e7c5fa8);
				}
				ServerTreeViewInfo serverTreeViewInfo3 = arg_205_0.FirstOrDefault(func3);
				if (serverTreeViewInfo3 != null)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cdfd15fd9767ca3c899334e0591fc3b13 = c4fb5da867a6dcef965e83d2e660c0364.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref serverTreeViewInfo3.cb5905b594e11dea2f73932df05981674);
					this.c7b27194d7b60931174f4e188c6dc1810(accTreeViewInfo, serverTreeViewInfo3);
					c9ed445f5332926a0c8d022c6e9fda720.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19332) != 0);
				}
			}
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19336) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19340) != 0);
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0005C558 File Offset: 0x0005A758
		private void c868c67d6fc0d52fc8a7700bde517c483(AccTreeViewInfo accTreeViewInfo, bool flag)
		{
			try
			{
				if (ccb3a37e39f5cb9245628b004349eac73.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_1C_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c868c67d6fc0d52fc8a7700bde517c483(AccTreeViewInfo, bool)).MethodHandle;
					}
					if (accTreeViewInfo == null)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					else
					{
						this.c940496334965a9294f8ecceea416c5df += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19344);
						if (flag)
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							this.c940496334965a9294f8ecceea416c5df = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19348);
						}
						if (this.c940496334965a9294f8ecceea416c5df > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19352))
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							this.c940496334965a9294f8ecceea416c5df = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19356);
							DataContractJsonSerializer dataContractJsonSerializer = c18f795c03ee7b0e7c51759a7c35c5749.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c04dcc400e5993ac92f15ae86bd631f53.cbac80c0356856482e0a93eed1c1fdf4f()));
							if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 != null)
							{
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
								List<ProductInstance<Core>>.Enumerator enumerator = c7ba0e077ebfbdbab21ede81ecbc0e192.c30767ddca1f9c207888833aea5b5fc61(c0d3f140a9df6c454307f702ba69fbb7f.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9));
								try
								{
									IL_39E:
									while (c55760734dddc1e862ce7f1946fe6efb7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator))
									{
										ProductInstance<Core> productInstance = ce631921f2559a566e8d29373f79c05a4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator);
										try
										{
											if (c5643ddf65713dd727df093959d31bf43.c30767ddca1f9c207888833aea5b5fc61(productInstance))
											{
												while (true)
												{
													switch (6)
													{
													case 0:
														continue;
													}
													break;
												}
											}
											else
											{
												bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19360) != 0;
												for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19364); i < c1ebcc0c26452f9a29fa51ec7f9630837.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19372))
												{
													if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(c11c31bdfea624b3ac6e7c486beaa3e3b.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i)), c21dc4f26741bed7d05cf42a99cd66fc3.c30767ddca1f9c207888833aea5b5fc61(productInstance)))
													{
														while (true)
														{
															switch (4)
															{
															case 0:
																continue;
															}
															break;
														}
														flag2 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19368) != 0);
														IL_17B:
														if (!flag2)
														{
															while (true)
															{
																switch (3)
																{
																case 0:
																	continue;
																}
																break;
															}
															PluginInfoDataGrid pluginInfoDataGrid = c3ae44a7a5e1999509fe6ff70d47c9913.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
															c87b740b8456d1d77f9722e1952792b07.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19376));
															c3ade045cbde340e637512c5311cdb3cc.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid, c21dc4f26741bed7d05cf42a99cd66fc3.c30767ddca1f9c207888833aea5b5fc61(productInstance));
															c5820d8028e78ab2a39c816c5308a460f.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid, AppMain.ca691be15ac02d2fd13604941dfb1f495.c7deaebfe91406a1fcedeb143f51ce1c9(c21dc4f26741bed7d05cf42a99cd66fc3.c30767ddca1f9c207888833aea5b5fc61(productInstance)));
															pluginInfoDataGrid.caa24630339480a12d11d102ecf4aa8a6 = accTreeViewInfo.c33cab44a92aeeafe67fd44b1b0a18483;
															pluginInfoDataGrid.c74e98237df2c01aebcb58e62b7657a32 = c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
															pluginInfoDataGrid.c120a76db91f7ca7eaf3a592702bd8b58 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19380) != 0);
															pluginInfoDataGrid.c9dfc5b53e96e74107a360b871efedc7f = c57bd84b1c447c517a9813e8b3ee3cba3.c30767ddca1f9c207888833aea5b5fc61(c3e3aba814e8983b83683eae58c902ac5.c30767ddca1f9c207888833aea5b5fc61(productInstance), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19384));
															PluginInfoDataGrid pluginInfoDataGrid2 = pluginInfoDataGrid;
															c937993deefb1bab2991fd800800fe43d.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), pluginInfoDataGrid2);
															if (accTreeViewInfo.c33cab44a92aeeafe67fd44b1b0a18483.ce90f2207bb4eaaea2488e91715b6c817)
															{
																while (true)
																{
																	switch (4)
																	{
																	case 0:
																		continue;
																	}
																	break;
																}
																int num = accTreeViewInfo.c33cab44a92aeeafe67fd44b1b0a18483.c16524733386e71ac4b79cb4b9485fdfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151221), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19388));
																for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19392); j < num; j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19408))
																{
																	string text = accTreeViewInfo.c33cab44a92aeeafe67fd44b1b0a18483.cd4f7b22e69ef8938ab19c0bf4bf0f0d4(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151244), j), "");
																	if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, ""))
																	{
																		while (true)
																		{
																			switch (7)
																			{
																			case 0:
																				continue;
																			}
																			break;
																		}
																		MemoryStream memoryStream = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
																		c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(memoryStream, cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19396), c3111dbd73271125c26adeed3dddb6f2f.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text));
																		cece621ea1589cc0c72148b25cde74f51.c30767ddca1f9c207888833aea5b5fc61(memoryStream, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19400));
																		PluginInfoDataGrid pluginInfoDataGrid3 = c23d78995eab231b9fb0f32d584ef4864.c9963fcf210a214a3206d6500f3b9397b(c8d871b7da42b19e432346220bcc023e0.c30767ddca1f9c207888833aea5b5fc61(dataContractJsonSerializer, memoryStream));
																		if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid2), cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid3), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19404) != 0) == 0)
																		{
																			while (true)
																			{
																				switch (2)
																				{
																				case 0:
																					continue;
																				}
																				break;
																			}
																			c5820d8028e78ab2a39c816c5308a460f.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid2, c71cc898384165c7d07deab305a0dd598.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid3));
																		}
																	}
																}
																while (true)
																{
																	switch (2)
																	{
																	case 0:
																		continue;
																	}
																	break;
																}
															}
														}
														goto IL_39E;
													}
												}
												while (true)
												{
													switch (1)
													{
													case 0:
														continue;
													}
													goto IL_17B;
												}
											}
										}
										catch (Exception ex)
										{
											cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
										}
									}
									while (true)
									{
										switch (4)
										{
										case 0:
											continue;
										}
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator).Dispose();
								}
							}
							List<string> list = AppMain.cdd1757f475d38dea2e5af9e3fac6be8c.ccd5c407a10e4d588dbe469e5f23ac127();
							for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19412); k < c917285c46e176f472f1c2753bdd49aab.c30767ddca1f9c207888833aea5b5fc61(list); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19460))
							{
								try
								{
									bool flag3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19416) != 0;
									for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19420); l < c1ebcc0c26452f9a29fa51ec7f9630837.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19428))
									{
										if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(c11c31bdfea624b3ac6e7c486beaa3e3b.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), l)), c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, k)))
										{
											while (true)
											{
												switch (3)
												{
												case 0:
													continue;
												}
												break;
											}
											flag3 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19424) != 0);
											IL_46F:
											if (!flag3)
											{
												while (true)
												{
													switch (2)
													{
													case 0:
														continue;
													}
													break;
												}
												PluginInfoDataGrid pluginInfoDataGrid4 = c3ae44a7a5e1999509fe6ff70d47c9913.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
												c87b740b8456d1d77f9722e1952792b07.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid4, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19432));
												c3ade045cbde340e637512c5311cdb3cc.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid4, c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, k));
												c5820d8028e78ab2a39c816c5308a460f.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid4, AppMain.ca691be15ac02d2fd13604941dfb1f495.c7deaebfe91406a1fcedeb143f51ce1c9(c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, k)));
												pluginInfoDataGrid4.caa24630339480a12d11d102ecf4aa8a6 = accTreeViewInfo.c33cab44a92aeeafe67fd44b1b0a18483;
												pluginInfoDataGrid4.c74e98237df2c01aebcb58e62b7657a32 = c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
												PluginInfoDataGrid pluginInfoDataGrid5 = pluginInfoDataGrid4;
												c937993deefb1bab2991fd800800fe43d.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), pluginInfoDataGrid5);
												if (accTreeViewInfo.c33cab44a92aeeafe67fd44b1b0a18483.ce90f2207bb4eaaea2488e91715b6c817)
												{
													while (true)
													{
														switch (6)
														{
														case 0:
															continue;
														}
														break;
													}
													int num2 = accTreeViewInfo.c33cab44a92aeeafe67fd44b1b0a18483.c16524733386e71ac4b79cb4b9485fdfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151221), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19436));
													for (int m = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19440); m < num2; m += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19456))
													{
														string text2 = accTreeViewInfo.c33cab44a92aeeafe67fd44b1b0a18483.cd4f7b22e69ef8938ab19c0bf4bf0f0d4(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151244), m), "");
														if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, ""))
														{
															while (true)
															{
																switch (2)
																{
																case 0:
																	continue;
																}
																break;
															}
															MemoryStream memoryStream2 = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
															c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(memoryStream2, cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text2), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19444), c3111dbd73271125c26adeed3dddb6f2f.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text2));
															cece621ea1589cc0c72148b25cde74f51.c30767ddca1f9c207888833aea5b5fc61(memoryStream2, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19448));
															PluginInfoDataGrid pluginInfoDataGrid6 = c23d78995eab231b9fb0f32d584ef4864.c9963fcf210a214a3206d6500f3b9397b(c8d871b7da42b19e432346220bcc023e0.c30767ddca1f9c207888833aea5b5fc61(dataContractJsonSerializer, memoryStream2));
															if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid5), cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid6), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19452) != 0) == 0)
															{
																while (true)
																{
																	switch (1)
																	{
																	case 0:
																		continue;
																	}
																	break;
																}
																c5820d8028e78ab2a39c816c5308a460f.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid5, c71cc898384165c7d07deab305a0dd598.c30767ddca1f9c207888833aea5b5fc61(pluginInfoDataGrid6));
															}
														}
													}
													while (true)
													{
														switch (5)
														{
														case 0:
															continue;
														}
														break;
													}
												}
											}
											goto IL_67B;
										}
									}
									while (true)
									{
										switch (7)
										{
										case 0:
											continue;
										}
										goto IL_46F;
									}
								}
								catch (Exception ex2)
								{
									c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154710), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2)));
								}
								IL_67B:;
							}
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						int n = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19464);
						while (n < c1ebcc0c26452f9a29fa51ec7f9630837.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
						{
							if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 == null)
							{
								goto IL_8D0;
							}
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.get_c6132b87d3ee6952aced554ae8aeed8be() == GameState.NotLogged)
							{
								goto IL_8D0;
							}
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							if ((int)accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.get_c6132b87d3ee6952aced554ae8aeed8be() == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19468))
							{
								goto IL_8D0;
							}
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							bool flag4 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19472) != 0;
							int num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19476);
							while (num3 < cfeba5c7bf03c635530eff9a3403b8e11.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.cc7f7c2eef3594f61015f80b6683b2dc9))
							{
								if (c11c31bdfea624b3ac6e7c486beaa3e3b.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), n).c120a76db91f7ca7eaf3a592702bd8b58)
								{
									while (true)
									{
										switch (3)
										{
										case 0:
											continue;
										}
										break;
									}
									if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7d6daec53efebbfc7bca9a3082928534.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.cc7f7c2eef3594f61015f80b6683b2dc9, num3).cc90f26a452ebadd2fb7e335341e9cdef, cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(c11c31bdfea624b3ac6e7c486beaa3e3b.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), n)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19480) != 0) == 0)
									{
										while (true)
										{
											switch (2)
											{
											case 0:
												continue;
											}
											break;
										}
										flag4 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19484) != 0);
										goto IL_87E;
									}
								}
								if (!c11c31bdfea624b3ac6e7c486beaa3e3b.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), n).c120a76db91f7ca7eaf3a592702bd8b58)
								{
									while (true)
									{
										switch (2)
										{
										case 0:
											continue;
										}
										break;
									}
									if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7d6daec53efebbfc7bca9a3082928534.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.cc7f7c2eef3594f61015f80b6683b2dc9, num3).cc90f26a452ebadd2fb7e335341e9cdef, c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33558), cdd9ebadbd88812a2cff5842e5829152c.c30767ddca1f9c207888833aea5b5fc61(c11c31bdfea624b3ac6e7c486beaa3e3b.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), n))), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19488) != 0) == 0)
									{
										while (true)
										{
											switch (6)
											{
											case 0:
												continue;
											}
											break;
										}
										flag4 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19492) != 0);
										goto IL_87E;
									}
								}
								num3 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19496);
								continue;
								IL_87E:
								if (flag4)
								{
									while (true)
									{
										switch (6)
										{
										case 0:
											continue;
										}
										break;
									}
									c87b740b8456d1d77f9722e1952792b07.c30767ddca1f9c207888833aea5b5fc61(c11c31bdfea624b3ac6e7c486beaa3e3b.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), n), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19500));
									goto IL_8F0;
								}
								c87b740b8456d1d77f9722e1952792b07.c30767ddca1f9c207888833aea5b5fc61(c11c31bdfea624b3ac6e7c486beaa3e3b.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), n), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19504));
								goto IL_8F0;
							}
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								goto IL_87E;
							}
							IL_8F0:
							n += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19512);
							continue;
							IL_8D0:
							c87b740b8456d1d77f9722e1952792b07.c30767ddca1f9c207888833aea5b5fc61(c11c31bdfea624b3ac6e7c486beaa3e3b.c30767ddca1f9c207888833aea5b5fc61(c98e17f305637eaa0764b031a1eb7982a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), n), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19508));
							goto IL_8F0;
						}
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
					}
				}
			}
			catch (Exception ex3)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154721), ex3));
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0005CF08 File Offset: 0x0005B108
		private void ce81442b3fa99d1ee563985966d316333(int num)
		{
			c29c9e2e3faaeaa8f38c43a85bf39d6d3.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f, c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
			c82ecc83577068b4801cb9db5653c2f36.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f));
			c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(121769));
			if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19516))
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_6E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ce81442b3fa99d1ee563985966d316333(int)).MethodHandle;
				}
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19520); i < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19524))
				{
					c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f), cbe1f0628b2f175e7b758facaccaa1116.c30767ddca1f9c207888833aea5b5fc61(c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, i)));
				}
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			else if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19528))
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19532); j < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19536))
				{
					c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f), cbe1f0628b2f175e7b758facaccaa1116.c30767ddca1f9c207888833aea5b5fc61(c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, j)));
				}
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			else if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19540))
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19544); k < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19548))
				{
					c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f), cbe1f0628b2f175e7b758facaccaa1116.c30767ddca1f9c207888833aea5b5fc61(c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, k)));
				}
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19552) != 0;
			if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19556))
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19560); l < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19572))
				{
					if ((int)c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c2d1e187c9efce20e55655d518436259c, l).cb5905b594e11dea2f73932df05981674 == num)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f, l + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19564));
						flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19568) != 0);
					}
				}
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!flag)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
				}
			}
			else if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19576))
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				for (int m = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19580); m < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34); m += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19592))
				{
					if ((int)c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.cd9db19395aea8d58426dab9ecf93bb34, m).cb5905b594e11dea2f73932df05981674 == num)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f, m + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19584));
						flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19588) != 0);
					}
				}
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!flag)
				{
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
				}
			}
			else if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19596))
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				for (int n = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19600); n < c3e56496cfdb9e6548fe2fafa8ca37b83.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300); n += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19612))
				{
					if ((int)c3296d2931507f61d4d30c922c63d138b.c30767ddca1f9c207888833aea5b5fc61(this.c211a8cb0fd0860bc469ed8ef20980300, n).cb5905b594e11dea2f73932df05981674 == num)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f, n + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19604));
						flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19608) != 0);
					}
				}
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			if (!flag)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				c7d10a7fbf02d1b9c6ba5e67a89c32492.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19616));
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0005D330 File Offset: 0x0005B530
		private void server_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.server_SelectionChanged(object, SelectionChangedEventArgs)).MethodHandle;
				}
				return;
			}
			if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(cc5ba717e158effd00e766e2a1f120307.cea69e7c4d1a729bd5783221de1566e79(sender)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19620))
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4 = c2b2703f8d5dda9c922e7b8a4df1cb1df.cea69e7c4d1a729bd5783221de1566e79(c0aa5b3e2cfcc489c6946a5bd3b9f4e52.c30767ddca1f9c207888833aea5b5fc61(cf351bf17b7cf14712eb4d1f631c937a4.cea69e7c4d1a729bd5783221de1566e79(c63eec5f5fa5b955ae3efb28da0d563e1.c30767ddca1f9c207888833aea5b5fc61(cccc4e141f0000245fdf2ebb12de1a445.c30767ddca1f9c207888833aea5b5fc61(e), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19624)))));
			if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153707)))
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c9870c914e51fdff3e46125bc50d1f172, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19628) != 0);
			}
			else
			{
				c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(this.c9870c914e51fdff3e46125bc50d1f172, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19632) != 0);
			}
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19636);
			c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cdfd15fd9767ca3c899334e0591fc3b13, ref num);
			this.ce81442b3fa99d1ee563985966d316333(num);
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19640) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19644) != 0);
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0005D4C4 File Offset: 0x0005B6C4
		private void CharacterNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.CharacterNumber_SelectionChanged(object, SelectionChangedEventArgs)).MethodHandle;
				}
				return;
			}
			if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(cc5ba717e158effd00e766e2a1f120307.cea69e7c4d1a729bd5783221de1566e79(sender)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19648))
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cdecfd55d76ff65b603e5b814c6504d6f = c2b2703f8d5dda9c922e7b8a4df1cb1df.cea69e7c4d1a729bd5783221de1566e79(c0aa5b3e2cfcc489c6946a5bd3b9f4e52.c30767ddca1f9c207888833aea5b5fc61(cf351bf17b7cf14712eb4d1f631c937a4.cea69e7c4d1a729bd5783221de1566e79(c63eec5f5fa5b955ae3efb28da0d563e1.c30767ddca1f9c207888833aea5b5fc61(cccc4e141f0000245fdf2ebb12de1a445.c30767ddca1f9c207888833aea5b5fc61(e), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19652)))));
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19656) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19660) != 0);
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0005D5DC File Offset: 0x0005B7DC
		private void description_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.description_TextChanged(object, TextChangedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.ca56117bd7a22712111d34d4bd3aa8642 = c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(c8c07d60fc8cfb7adc05a6517499994fc.cea69e7c4d1a729bd5783221de1566e79(sender));
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19664) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19668) != 0);
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
			c8ccf32dc3bb8537a64795414cd54b8e1.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.ca56117bd7a22712111d34d4bd3aa8642);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0005D6C0 File Offset: 0x0005B8C0
		private void MetroWindow_Activated(object sender, EventArgs e)
		{
			c75607ccd6667b415790d680d7353a18b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new Thickness(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(19672)));
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0005D6E4 File Offset: 0x0005B8E4
		private void MetroWindow_Deactivated(object sender, EventArgs e)
		{
			c75607ccd6667b415790d680d7353a18b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new Thickness(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(19680)));
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0005D708 File Offset: 0x0005B908
		private void login_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.login_TextChanged(object, TextChangedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6 = c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(c8c07d60fc8cfb7adc05a6517499994fc.cea69e7c4d1a729bd5783221de1566e79(sender));
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19688) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19692) != 0);
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0005D7D8 File Offset: 0x0005B9D8
		private void password_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.password_TextChanged(object, TextChangedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.caee1e47a08a4ecec009fb2516f979104 = c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(c8c07d60fc8cfb7adc05a6517499994fc.cea69e7c4d1a729bd5783221de1566e79(sender));
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19696) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19700) != 0);
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0005D8A8 File Offset: 0x0005BAA8
		private void UseSocks5_Checked(object sender, RoutedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.UseSocks5_Checked(object, RoutedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			object arg_76_0 = this.cefce72c9f3171228780df28ff61afccb;
			bool? flag = ccbea4253e9b7a3696e50409b304aa41f.c30767ddca1f9c207888833aea5b5fc61(this.cd9d6c8eccb641592989df004f1e1c45f);
			c819e7e8fce096f7f7df9620bf2d94bcd.c30767ddca1f9c207888833aea5b5fc61(arg_76_0, cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag));
			cd4d5a5684d153eefc4ebe1d89a85e677 arg_98_0 = accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430;
			bool? flag2 = ccbea4253e9b7a3696e50409b304aa41f.c30767ddca1f9c207888833aea5b5fc61(this.cd9d6c8eccb641592989df004f1e1c45f);
			arg_98_0.c805e30d018811e2793f3357a1dd68693 = cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag2);
			bool flag3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19704) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag3);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19708) != 0);
			}
			finally
			{
				if (flag3)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0005D9A4 File Offset: 0x0005BBA4
		private void proxyIp_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.proxyIp_TextChanged(object, TextChangedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfb089fcc005d120966aebcd807c953eb = c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(c8c07d60fc8cfb7adc05a6517499994fc.cea69e7c4d1a729bd5783221de1566e79(sender));
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19712) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19716) != 0);
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0005DA74 File Offset: 0x0005BC74
		private void proxyPort_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.proxyPort_TextChanged(object, TextChangedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c43acd5b8aee8aac3eb34d311d73db4b9 = c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(c8c07d60fc8cfb7adc05a6517499994fc.cea69e7c4d1a729bd5783221de1566e79(sender));
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19720) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19724) != 0);
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0005DB44 File Offset: 0x0005BD44
		private void proxyLogin_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.proxyLogin_TextChanged(object, TextChangedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c19b1d008780db8f45326d62e4ae97cf1 = c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(c8c07d60fc8cfb7adc05a6517499994fc.cea69e7c4d1a729bd5783221de1566e79(sender));
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19728) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19732) != 0);
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0005DC14 File Offset: 0x0005BE14
		private void proxyPassword_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.proxyPassword_TextChanged(object, TextChangedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.c5448fced558b14e475d62f73ac05a864 = c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(c8c07d60fc8cfb7adc05a6517499994fc.cea69e7c4d1a729bd5783221de1566e79(sender));
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19736) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19740) != 0);
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0005DCE4 File Offset: 0x0005BEE4
		private void Window_Closing(object sender, CancelEventArgs e)
		{
			if (c7149d99595dd0da0305bdacf045443ba.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154798), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154853), (MessageBoxButton)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19744)) == (MessageBoxResult)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19748))
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_47_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.Window_Closing(object, CancelEventArgs)).MethodHandle;
				}
				cdd6e82cc82d0907870bcea6f8d892056.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19752));
				return;
			}
			cafe74e9c22dd716d03dec340fa88fddb.c30767ddca1f9c207888833aea5b5fc61(e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19756) != 0);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0005DD5C File Offset: 0x0005BF5C
		private void c3997da75761c4b628d031359dc2a7bd8()
		{
			try
			{
				if (!AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c316deed210266991ce13d8e6567df5b6())
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_20_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c3997da75761c4b628d031359dc2a7bd8()).MethodHandle;
					}
				}
				else
				{
					string text = "";
					if (c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154872)))
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						text = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154872);
					}
					else
					{
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19760); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19768); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19764))
						{
							if (c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149678), i, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154915))))
							{
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									break;
								}
								text = cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149678), i, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154915));
								goto IL_EE;
							}
						}
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					IL_EE:
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, ""))
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19772); j < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19840); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19836))
						{
							string text2 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154936));
							if (j != 0)
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								text2 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref j));
							}
							if (!c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2))
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								c9af1228cdf2eb4a3c82bce956b7a756e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2);
							}
							if (c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154947))))
							{
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
								DirectoryInfo directoryInfo = ce4ba0c8fd0b6fcc79ac40fcd8de6bf76.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154947)));
								FileInfo[] array = c0a5b0250d6bba50a84413b0520f93b3e.c30767ddca1f9c207888833aea5b5fc61(directoryInfo);
								for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19776); k < (int)c4040b9940e01a6827dacb485503952c1.cc0906fa561b9c6076f6cb6643cecb5e3(array); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19780))
								{
									FileInfo fileInfo = array[k];
									c6971655edbfaeb5a2507782a42d62634.c30767ddca1f9c207888833aea5b5fc61(fileInfo);
								}
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								DirectoryInfo[] array2 = c7404c4a00793b12a083073e99723b1d5.c30767ddca1f9c207888833aea5b5fc61(directoryInfo);
								for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19784); l < (int)c17d55676ad7717648666aec85f39b64a.cc0906fa561b9c6076f6cb6643cecb5e3(array2); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19792))
								{
									DirectoryInfo directoryInfo2 = array2[l];
									c7a4d99101c97116306e1f2c5cc2fd237.c30767ddca1f9c207888833aea5b5fc61(directoryInfo2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19788) != 0);
								}
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									break;
								}
							}
							if (c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154964))))
							{
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									break;
								}
								DirectoryInfo directoryInfo3 = ce4ba0c8fd0b6fcc79ac40fcd8de6bf76.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154964)));
								FileInfo[] array3 = c0a5b0250d6bba50a84413b0520f93b3e.c30767ddca1f9c207888833aea5b5fc61(directoryInfo3);
								for (int m = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19796); m < (int)c4040b9940e01a6827dacb485503952c1.cc0906fa561b9c6076f6cb6643cecb5e3(array3); m += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19800))
								{
									FileInfo fileInfo2 = array3[m];
									c6971655edbfaeb5a2507782a42d62634.c30767ddca1f9c207888833aea5b5fc61(fileInfo2);
								}
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								DirectoryInfo[] array4 = c7404c4a00793b12a083073e99723b1d5.c30767ddca1f9c207888833aea5b5fc61(directoryInfo3);
								for (int n = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19804); n < (int)c17d55676ad7717648666aec85f39b64a.cc0906fa561b9c6076f6cb6643cecb5e3(array4); n += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19812))
								{
									DirectoryInfo directoryInfo4 = array4[n];
									c7a4d99101c97116306e1f2c5cc2fd237.c30767ddca1f9c207888833aea5b5fc61(directoryInfo4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19808) != 0);
								}
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
							}
							if (!c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154973))))
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								c9af1228cdf2eb4a3c82bce956b7a756e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154973)));
							}
							if (c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154973))))
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								DirectoryInfo directoryInfo5 = ce4ba0c8fd0b6fcc79ac40fcd8de6bf76.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154973)));
								FileInfo[] array5 = c0a5b0250d6bba50a84413b0520f93b3e.c30767ddca1f9c207888833aea5b5fc61(directoryInfo5);
								for (int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19816); num < (int)c4040b9940e01a6827dacb485503952c1.cc0906fa561b9c6076f6cb6643cecb5e3(array5); num += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19820))
								{
									FileInfo fileInfo3 = array5[num];
									c6971655edbfaeb5a2507782a42d62634.c30767ddca1f9c207888833aea5b5fc61(fileInfo3);
								}
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									break;
								}
								DirectoryInfo[] array6 = c7404c4a00793b12a083073e99723b1d5.c30767ddca1f9c207888833aea5b5fc61(directoryInfo5);
								for (int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19824); num2 < (int)c17d55676ad7717648666aec85f39b64a.cc0906fa561b9c6076f6cb6643cecb5e3(array6); num2 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19832))
								{
									DirectoryInfo directoryInfo6 = array6[num2];
									c7a4d99101c97116306e1f2c5cc2fd237.c30767ddca1f9c207888833aea5b5fc61(directoryInfo6, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19828) != 0);
								}
								while (true)
								{
									switch (6)
									{
									case 0:
										continue;
									}
									break;
								}
								c391339cf6b314898d046009622c36fbb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154982)), ca6e3dc8376c18f2a81b5898e3cd7d5ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
								c391339cf6b314898d046009622c36fbb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155013)), c829cd45c64ec49ea71cc0adbf1f25517.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
								c391339cf6b314898d046009622c36fbb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155044)), ca2e5917a5c372ddbfcf9f879da5111ca.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
								c391339cf6b314898d046009622c36fbb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155069)), c734e6c378de2196e3d9d2aa9e8ff32c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
							}
						}
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0005E2A8 File Offset: 0x0005C4A8
		private void cc0f65d69734f191efe96f147a2cf9626(c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e)
		{
			try
			{
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155110));
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19844));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19848), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19852), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19856));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_6E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.cc0f65d69734f191efe96f147a2cf9626(c41303f5801b83831668dac7d66691e12)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19860));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							return;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19864)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19868));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19872));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate5f == null)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate5f = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.c0630c9865e5d97f33fbbdde944073ef2);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate5f);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155213), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155250), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155257), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19876)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155308), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19880)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155345), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19884)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155493), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19888)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155536), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19892)));
						ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155575), c41303f5801b83831668dac7d66691e.c2d41e4474230ee8f1d316ffbe592fa64);
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155602), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19896)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155651), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19900)));
						ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155716), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
						c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
						byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
						c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(networkStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19904), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
						cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						int num = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(networkStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19908), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
						c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19912), num);
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0005E6DC File Offset: 0x0005C8DC
		private void c14731e59c821a2f13c03c544e2bbd309(c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e)
		{
			try
			{
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155739));
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19916));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19920), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19924), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19928));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_6E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c14731e59c821a2f13c03c544e2bbd309(c41303f5801b83831668dac7d66691e12)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19932));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							return;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19936)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19940));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19944));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate61 == null)
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate61 = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.ccaf16cc71c0f9e14d0b53c489a6b523d);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate61);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155213), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155250), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155901), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19948)));
						ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155716), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155966), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19952)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155993), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19956)));
						ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155575), c41303f5801b83831668dac7d66691e.c2d41e4474230ee8f1d316ffbe592fa64);
						c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
						byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
						c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(networkStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19960), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
						cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						int num = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(networkStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19964), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
						c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19968), num);
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0005EA78 File Offset: 0x0005CC78
		private void ce1349517f2a0d77011a835bf5356ab9f(c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e)
		{
			try
			{
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156040));
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19972));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19976), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19980), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19984));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_6E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ce1349517f2a0d77011a835bf5356ab9f(c41303f5801b83831668dac7d66691e12)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19988));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							return;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19992)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(19996));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20000));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate63 == null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate63 = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.ce40324fec72ba8769cbca6c1fa80eb54);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate63);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155213), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155250), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155602), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20004)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155651), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20008)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156151), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20012)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156210), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20016)));
						ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155716), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
						c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
						byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
						c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(networkStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20020), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
						cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						int num = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(networkStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20024), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
						c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20028), num);
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0005EE20 File Offset: 0x0005D020
		private void cf6f5a9939957cdc588fa6e807fd553fa(c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e)
		{
			try
			{
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156261));
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20032));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20036), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20040), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20044));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_6E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.cf6f5a9939957cdc588fa6e807fd553fa(c41303f5801b83831668dac7d66691e12)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20048));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							return;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20052)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20056));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20060));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate65 == null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate65 = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.c96c76dae5667f7f46e4ce73776016eac);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate65);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155213), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155250), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155602), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20064)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155651), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20068)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156151), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20072)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156210), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20076)));
						ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155716), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
						c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
						byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
						c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(networkStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20080), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
						cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						int num = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(networkStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20084), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
						c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20088), num);
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0005F1C8 File Offset: 0x0005D3C8
		private void ce29d501176cac41bb18d4ce01c3cc625(c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e)
		{
			try
			{
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156384));
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20092));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20096), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20100), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20104));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_6E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ce29d501176cac41bb18d4ce01c3cc625(c41303f5801b83831668dac7d66691e12)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20108));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							return;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20112)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20116));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20120));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate67 == null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate67 = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.c384b6878438c08d54d15066b713740bd);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate67);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155213), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155250), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155602), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20124)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155651), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20128)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156151), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20132)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156210), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20136)));
						ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155716), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
						c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
						byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
						c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(networkStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20140), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
						cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						int num = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(networkStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20144), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
						c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20148), num);
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0005F570 File Offset: 0x0005D770
		public static bool c122c43a3e5a31be8efbbf95676824fac(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20152) != 0;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0005F588 File Offset: 0x0005D788
		private bool c02dadf815997d3bbbc04bc40361b41a7(string text, string text2, c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e)
		{
			bool result;
			try
			{
				string text3 = "";
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2);
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20156));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20160), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20164), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20168));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_72_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c02dadf815997d3bbbc04bc40361b41a7(string, string, c41303f5801b83831668dac7d66691e12)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20172));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20176) != 0);
							return result;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20180)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (6)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20184));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20188));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate69 == null)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate69 = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.cd496a8d820d923d6c95458892c88d4af);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate69);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						SslStream sslStream = c2322a882aa1a5f71c7eebbebfe6a38d1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(networkStream, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20192) != 0, new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.c122c43a3e5a31be8efbbf95676824fac));
						try
						{
							try
							{
								c11d64e6f23e2972bb40d6fb8bdfe67ea.c30767ddca1f9c207888833aea5b5fc61(sslStream, cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
							}
							catch (Exception ex)
							{
								c8761875271fc238365016dcd30db760f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
							}
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155213), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156509), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri));
							c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155901), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20196)));
							ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155716), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
							c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155966), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20200)));
							c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155993), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20204)));
							ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156518), c3111dbd73271125c26adeed3dddb6f2f.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text));
							c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156561), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20208)));
							c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
							c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, text);
							byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
							c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(sslStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20212), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
							cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(sslStream);
							int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20216);
							int num2;
							do
							{
								num2 = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(sslStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20220), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
								string text4 = c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20224), num2);
								text3 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text3, text4);
								if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156660)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20228))
								{
									while (true)
									{
										switch (2)
										{
										case 0:
											continue;
										}
										break;
									}
									num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20232);
								}
								else if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149328)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20236))
								{
									while (true)
									{
										switch (1)
										{
										case 0:
											continue;
										}
										break;
									}
									if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20240))
									{
										while (true)
										{
											switch (2)
											{
											case 0:
												continue;
											}
											break;
										}
										int num3 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20244);
										int num4 = ce02f80c58d177f6269598f2b1d9425bd.c30767ddca1f9c207888833aea5b5fc61(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337), cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20248));
										string text5 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text3, num3, num4 - num3);
										num = c606fafaa600fdd723e91114a8f450cda.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text5);
									}
									if (num != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20252))
									{
										while (true)
										{
											switch (4)
											{
											case 0:
												continue;
											}
											break;
										}
										int num5 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149328));
										int num6 = c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text3);
										if (num == num6 - num5 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20256))
										{
											while (true)
											{
												switch (3)
												{
												case 0:
													continue;
												}
												break;
											}
											num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20260);
										}
									}
								}
							}
							while (num2 != 0);
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						finally
						{
							if (sslStream != null)
							{
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
								cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sslStream);
							}
						}
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
				ced67d0527f85483071a0086e7d3ef52e ced67d0527f85483071a0086e7d3ef52e = new ced67d0527f85483071a0086e7d3ef52e(text3);
				try
				{
					StreamReader streamReader = cf2ae6da201b2402266aad1d4824076e7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c19c69889355b14ea1c60d173f82431b1.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e));
					try
					{
						string text6 = c826b756047d7eec56cd86b5698fcdad2.c30767ddca1f9c207888833aea5b5fc61(streamReader);
						if (cd6fbb5d1a3a46ec28e6c5de1403b51b9.c30767ddca1f9c207888833aea5b5fc61(c1c242d1bee0107baba5957289ba1ccbf.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156700)) != null)
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd6fbb5d1a3a46ec28e6c5de1403b51b9.c30767ddca1f9c207888833aea5b5fc61(c1c242d1bee0107baba5957289ba1ccbf.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156700))[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20264)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156757)))
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								if (cd6fbb5d1a3a46ec28e6c5de1403b51b9.c30767ddca1f9c207888833aea5b5fc61(c1c242d1bee0107baba5957289ba1ccbf.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156768)) != null)
								{
									while (true)
									{
										switch (5)
										{
										case 0:
											continue;
										}
										break;
									}
									if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd6fbb5d1a3a46ec28e6c5de1403b51b9.c30767ddca1f9c207888833aea5b5fc61(c1c242d1bee0107baba5957289ba1ccbf.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156768))[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20268)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156807)))
									{
										while (true)
										{
											switch (4)
											{
											case 0:
												continue;
											}
											break;
										}
										c41303f5801b83831668dac7d66691e.c7b389d4ea5b6049ba644f5a877e42072 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20272) != 0);
										result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20276) != 0);
										return result;
									}
								}
							}
						}
						if (cd6fbb5d1a3a46ec28e6c5de1403b51b9.c30767ddca1f9c207888833aea5b5fc61(c1c242d1bee0107baba5957289ba1ccbf.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156768)) != null)
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd6fbb5d1a3a46ec28e6c5de1403b51b9.c30767ddca1f9c207888833aea5b5fc61(c1c242d1bee0107baba5957289ba1ccbf.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156768))[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20280)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156807)))
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								c41303f5801b83831668dac7d66691e.c30cd27e1520c218c4b0f288768bcb3bb = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20284) != 0);
								result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20288) != 0);
								return result;
							}
						}
						if (cd6fbb5d1a3a46ec28e6c5de1403b51b9.c30767ddca1f9c207888833aea5b5fc61(c1c242d1bee0107baba5957289ba1ccbf.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156768)) != null)
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd6fbb5d1a3a46ec28e6c5de1403b51b9.c30767ddca1f9c207888833aea5b5fc61(c1c242d1bee0107baba5957289ba1ccbf.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156768))[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20292)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156832)))
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								c41303f5801b83831668dac7d66691e.cd863c162c62aa74d7467903f06abd2c5 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20296) != 0);
								result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20300) != 0);
								return result;
							}
						}
						object arg_7ED_0 = text6;
						char[] array4 = ce711c40a529b8c0cc2cbe69b29c59ef6.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20304));
						array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20308)] = (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20312);
						string[] array5 = c52574d721e2ddb698348d193bdc6ed4c.c30767ddca1f9c207888833aea5b5fc61(arg_7ED_0, array4, (StringSplitOptions)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20316));
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20320); i < (int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array5); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20324))
						{
							array5[i] = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(array5[i], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156861), "");
						}
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						string text7 = "";
						string[] array6 = array5;
						for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20328); j < (int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array6); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20332))
						{
							string text8 = array6[j];
							if (!this.cad36e35df87ec20dc48a1cdb74643df1(text8))
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								text7 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text7, text8);
							}
						}
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						object arg_8F1_0 = text7;
						string[] array7 = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20336));
						array7[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20340)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156864);
						string[] array8 = cc19ced84c86a267bd615bafbf2c5917a.c30767ddca1f9c207888833aea5b5fc61(arg_8F1_0, array7, (StringSplitOptions)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20344));
						for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20348); k < (int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array8); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20352))
						{
							array8[k] = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156885), array8[k]);
						}
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						string[] array9 = array8;
						for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20356); l < (int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array9); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20384))
						{
							string text9 = array9[l];
							if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text9, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156908)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20360))
							{
								while (true)
								{
									switch (6)
									{
									case 0:
										continue;
									}
									break;
								}
								int num7 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text9, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156864));
								int num8 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text9, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156961));
								int num9 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text9, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157000));
								if (num7 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20364))
								{
									while (true)
									{
										switch (1)
										{
										case 0:
											continue;
										}
										break;
									}
									if (num8 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20368))
									{
										while (true)
										{
											switch (5)
											{
											case 0:
												continue;
											}
											break;
										}
										if (num8 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20372))
										{
											while (true)
											{
												switch (7)
												{
												case 0:
													continue;
												}
												break;
											}
											c41303f5801b83831668dac7d66691e.cf7fc9669e7e05a29179b2df480fb1c86 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text9, num7, num8 - num7);
											c41303f5801b83831668dac7d66691e.cf7fc9669e7e05a29179b2df480fb1c86 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(c41303f5801b83831668dac7d66691e.cf7fc9669e7e05a29179b2df480fb1c86, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118823), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119792));
											c41303f5801b83831668dac7d66691e.cbab51a48bb652077efbc1d16e7db1697 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text9, num8, num9 - num8 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20376));
											int num10 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text9, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157027)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20380);
											int num11 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text9, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157060));
											c41303f5801b83831668dac7d66691e.c2d41e4474230ee8f1d316ffbe592fa64 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text9, num10, num11 - num10);
										}
									}
								}
							}
						}
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20388) != 0);
					}
					finally
					{
						if (streamReader != null)
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(streamReader);
						}
					}
				}
				finally
				{
					if (ced67d0527f85483071a0086e7d3ef52e != null)
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e);
					}
				}
			}
			catch (Exception ex2)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20392) != 0);
			}
			return result;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000601A4 File Offset: 0x0005E3A4
		private void ce7b7bd1b30026b9b60631aeecc14a23e(c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e)
		{
			try
			{
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157095));
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20396));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20400), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20404), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20408));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_6E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ce7b7bd1b30026b9b60631aeecc14a23e(c41303f5801b83831668dac7d66691e12)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20412));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							return;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20416)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20420));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20424));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate6b == null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate6b = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.c89cd6ca4c368a3e345b3de9f4f88c765);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate6b);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155213), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155250), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155901), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20428)));
						ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155716), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155966), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20432)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155993), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20436)));
						c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
						byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
						c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(networkStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20440), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
						cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						int num = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(networkStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20444), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
						c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20448), num);
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00060528 File Offset: 0x0005E728
		private void c9184c74f25dab65adf90c873d9a7fdfb(c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e)
		{
			try
			{
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157222));
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20452));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20456), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20460), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20464));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_6E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c9184c74f25dab65adf90c873d9a7fdfb(c41303f5801b83831668dac7d66691e12)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20468));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							return;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20472)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20476));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20480));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate6d == null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate6d = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.cb6d87c96286ec427ae0f02f93e3d162e);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate6d);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155213), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155250), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155901), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20484)));
						ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155716), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155966), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20488)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155993), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20492)));
						c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
						byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
						c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(networkStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20496), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
						cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						int num = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(networkStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20500), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
						c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20504), num);
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x000608AC File Offset: 0x0005EAAC
		private bool c99702ea1139ca53449d4279abb433732(c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e)
		{
			bool result;
			try
			{
				string text = "";
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157358));
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20508));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20512), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20516), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20520));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_76_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c99702ea1139ca53449d4279abb433732(c41303f5801b83831668dac7d66691e12)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20524));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20528) != 0);
							return result;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20532)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20536));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20540));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate6f == null)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate6f = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.c27b46e49e9cb1970039e43945d09cba0);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate6f);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155213), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155250), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155901), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20544)));
						ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155716), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155966), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20548)));
						c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(155993), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20552)));
						c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
						byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
						c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(networkStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20556), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
						cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20560);
						int num2;
						do
						{
							num2 = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(networkStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20564), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
							text = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20568), num2));
							if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149328)) != 0)
							{
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									break;
								}
								if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20572))
								{
									while (true)
									{
										switch (1)
										{
										case 0:
											continue;
										}
										break;
									}
									int num3 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20576);
									int num4 = ce02f80c58d177f6269598f2b1d9425bd.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337), cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20580));
									string text2 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, num3, num4 - num3);
									num = c606fafaa600fdd723e91114a8f450cda.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2);
								}
								if (num != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20584))
								{
									while (true)
									{
										switch (5)
										{
										case 0:
											continue;
										}
										break;
									}
									int num5 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149328)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20588);
									int num6 = c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text);
									if (num == num6 - num5)
									{
										while (true)
										{
											switch (1)
											{
											case 0:
												continue;
											}
											break;
										}
										num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20592);
									}
								}
							}
						}
						while (num2 != 0);
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(text);
						if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157477)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20596))
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20600) != 0);
						}
						else
						{
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20604) != 0);
						}
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20608) != 0);
			}
			return result;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00060DE0 File Offset: 0x0005EFE0
		private bool cad36e35df87ec20dc48a1cdb74643df1(string text)
		{
			try
			{
				c8c4c54b74f9d0fe7e4c4bd3613125544.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text);
				bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20612) != 0;
				return result;
			}
			catch
			{
			}
			try
			{
				c9ac3862bac44a44b328cf137d8c3993f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20616));
				bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20620) != 0;
				return result;
			}
			catch
			{
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20624) != 0;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00060E54 File Offset: 0x0005F054
		private bool c9a96b509d78182d92ce8572154236be3(string text, string text2, c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e, bool flag = false)
		{
			bool result;
			try
			{
				string text3 = "";
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2);
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20628));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20632), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20636), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20640));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_72_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c9a96b509d78182d92ce8572154236be3(string, string, c41303f5801b83831668dac7d66691e12, bool)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20644));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20648) != 0);
							return result;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20652)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20656));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20660));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate71 == null)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate71 = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.cceec2213c64b82e4fea5675c51c5e9ce);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate71);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						SslStream sslStream = c76dddf1520614371110b313df8c1ced9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(networkStream, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20664) != 0, new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.c122c43a3e5a31be8efbbf95676824fac), caacaf1de8ee5efc5c5ff8d3ff3f48a17.c8a754f5f2ca4adde825691a9c31a0e83);
						try
						{
							c11d64e6f23e2972bb40d6fb8bdfe67ea.c30767ddca1f9c207888833aea5b5fc61(sslStream, cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
							ce4341ddc100347512b84287c8827f1c0.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157490), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156509), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157570), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157583));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157590), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157611));
							ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156518), c3111dbd73271125c26adeed3dddb6f2f.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text));
							ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157644), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157683));
							c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
							c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, text);
							byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
							c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(sslStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20668), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
							cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(sslStream);
							int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20672);
							int num2;
							do
							{
								num2 = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(sslStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20676), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
								text3 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text3, c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20680), num2));
								if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149328)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20684))
								{
									while (true)
									{
										switch (1)
										{
										case 0:
											continue;
										}
										break;
									}
									if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20688))
									{
										while (true)
										{
											switch (3)
											{
											case 0:
												continue;
											}
											break;
										}
										int num3 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20692);
										int num4 = ce02f80c58d177f6269598f2b1d9425bd.c30767ddca1f9c207888833aea5b5fc61(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337), cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20696));
										string text4 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text3, num3, num4 - num3);
										num = c606fafaa600fdd723e91114a8f450cda.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text4);
									}
									if (num != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20700))
									{
										while (true)
										{
											switch (2)
											{
											case 0:
												continue;
											}
											break;
										}
										int num5 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149328));
										int num6 = c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text3);
										if (num == num6 - num5 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20704))
										{
											while (true)
											{
												switch (2)
												{
												case 0:
													continue;
												}
												break;
											}
											num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20708);
										}
									}
								}
							}
							while (num2 != 0);
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						finally
						{
							if (sslStream != null)
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sslStream);
							}
						}
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
				ced67d0527f85483071a0086e7d3ef52e ced67d0527f85483071a0086e7d3ef52e = new ced67d0527f85483071a0086e7d3ef52e(text3);
				try
				{
					StreamReader streamReader = cf2ae6da201b2402266aad1d4824076e7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c19c69889355b14ea1c60d173f82431b1.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e));
					try
					{
						string text5 = c826b756047d7eec56cd86b5698fcdad2.c30767ddca1f9c207888833aea5b5fc61(streamReader);
						result = this.c4017b48edd5871efb1563c699df02bd9(text5, c41303f5801b83831668dac7d66691e, flag);
					}
					finally
					{
						if (streamReader != null)
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(streamReader);
						}
					}
				}
				finally
				{
					if (ced67d0527f85483071a0086e7d3ef52e != null)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				this.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157750)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20712) != 0);
			}
			return result;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0006149C File Offset: 0x0005F69C
		private bool c4017b48edd5871efb1563c699df02bd9(string text, c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e, bool flag)
		{
			bool result;
			try
			{
				if (flag)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_18_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c4017b48edd5871efb1563c699df02bd9(string, c41303f5801b83831668dac7d66691e12, bool)).MethodHandle;
					}
					int num = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157906));
					if (num != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20716))
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						int num2 = num + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20720);
						int num3 = c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20724);
						c41303f5801b83831668dac7d66691e.cefadbd31843b23ae8080afc73c57d963 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, num2, num3 - num2);
						c41303f5801b83831668dac7d66691e.c668c9290d4eea86e1d25b03108451ae9 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, num2, num3 - num2);
					}
					num = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157931));
					if (num != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20728))
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						int num4 = num + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20732);
						int num5 = cc65bd59f017de55299dbd72ca0ba18c2.c30767ddca1f9c207888833aea5b5fc61(text, (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20736), num4);
						c41303f5801b83831668dac7d66691e.ce9cc237e4092e91790e871377df43e68 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, num4, num5 - num4);
					}
					num = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157942));
					if (num != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20740))
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						int num6 = num + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20744);
						int num7 = cc65bd59f017de55299dbd72ca0ba18c2.c30767ddca1f9c207888833aea5b5fc61(text, (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20748), num6);
						c41303f5801b83831668dac7d66691e.c5f93cb3d18e7f9a9cbbbc10374f403be = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, num6, num7 - num6);
					}
				}
				if (!flag)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					XDocument xDocument = c203d08dd7dff1ab79e06c51a74ec193c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text);
					if (c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument) == null)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20752) != 0);
						return result;
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157977)))), string.Empty))
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.cf814b04482d1c4f2e113abe596b1a4ab = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157977))));
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157996)))), string.Empty))
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.cefadbd31843b23ae8080afc73c57d963 = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157996))));
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158017)))), string.Empty))
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.c68bbc00882446045216d61e06d6b761e = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158017))));
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158024)))), string.Empty))
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.cdcf7b7ebee934abc60dadeab366145f9 = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158024))));
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158049)))), string.Empty))
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.c4ea03b5c3f897e463787adc87bd6a71d = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158049))));
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158060)))), string.Empty))
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.ce40546abf61e7d65dc954df9123f32fc = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158060))));
					}
					IEnumerator<XElement> enumerator = ca707e8a7610738a2ed391553360083e6.c30767ddca1f9c207888833aea5b5fc61(c846e8cb526855c921c20f97c028edb83.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158073))));
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
						{
							XElement xElement = ce7145ef41d498a785aa89705931f51ff.c30767ddca1f9c207888833aea5b5fc61(enumerator);
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(xElement, ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158088)))), string.Empty))
							{
								while (true)
								{
									switch (6)
									{
									case 0:
										continue;
									}
									break;
								}
								if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(xElement, ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158088)))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158093)))
								{
									while (true)
									{
										switch (6)
										{
										case 0:
											continue;
										}
										break;
									}
									c41303f5801b83831668dac7d66691e.c77b78ee640a1f0b052729afc9b673c95 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20756) != 0);
								}
							}
						}
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
						}
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158106)))), string.Empty))
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.ca272c82a278446087fe3f9ff0fcaeb36 = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158106))));
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158117)))), string.Empty))
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.cf750820b650ce2647eb21cddf9e56c17 = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158117))));
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158140)))), string.Empty))
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.c93b4a6a48ff16dfe61e8f7bddb25358c = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158140))));
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158159)))), string.Empty))
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.c4537e7e4f0525300135b26662a8d3802 = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158159))));
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158176)))), string.Empty))
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.c405e537f1c0f9ad0df4db23b46591ea7 = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158176))));
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158189)))), string.Empty))
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.c03f8978984671fce959e74a1d566ffa6 = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158189))));
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158196)))), string.Empty))
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.c0b458c84121686eddf965dbd8a522b60 = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158196))));
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158205)))), string.Empty))
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						c41303f5801b83831668dac7d66691e.c75a61b9b1579790f1c9d1020afc9b45b = this.cedb7dc066481dba6ce06ac57d60e9973(c3b774160f20647b1b5c43900a5355336.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158205))));
					}
				}
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20760) != 0);
			}
			catch (Exception)
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20764) != 0);
			}
			return result;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00061DE0 File Offset: 0x0005FFE0
		private string c3309aae1199d58439a8a86a478d6fab2(int num)
		{
			StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20768); i < num; i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20788))
			{
				char c = cc79e0333f52ad1bc58345781fbefdb4c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cee40d8a4497ed295284839996c40f8aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3dae4afdba118d64ec6293e657258fb4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(20772) * c8e5ae25e55b831b55396e7a91819f446.c30767ddca1f9c207888833aea5b5fc61(cbf4111912aed594f2b4372828dd95aa3.random) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(20780))));
				cddb2af83f70c2e0429d8788f32e30094.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c);
			}
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			if (!true)
			{
				RuntimeMethodHandle arg_7E_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c3309aae1199d58439a8a86a478d6fab2(int)).MethodHandle;
			}
			return cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00061E74 File Offset: 0x00060074
		private bool c016fe8ab8aacac01131bd5bbb8bfcf24(string text, string text2, c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e, string text3)
		{
			bool result;
			try
			{
				string text4 = "";
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2);
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20792));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20796), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20800), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20804));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_72_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c016fe8ab8aacac01131bd5bbb8bfcf24(string, string, c41303f5801b83831668dac7d66691e12, string)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20808));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20812) != 0);
							return result;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20816)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (6)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20820));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20824));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate73 == null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate73 = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.c473bf4dbf6332266ad2f5716b83038e4);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate73);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						SslStream sslStream = c76dddf1520614371110b313df8c1ced9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(networkStream, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20828) != 0, new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.c122c43a3e5a31be8efbbf95676824fac), caacaf1de8ee5efc5c5ff8d3ff3f48a17.c8a754f5f2ca4adde825691a9c31a0e83);
						try
						{
							c11d64e6f23e2972bb40d6fb8bdfe67ea.c30767ddca1f9c207888833aea5b5fc61(sslStream, cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
							ce4341ddc100347512b84287c8827f1c0.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157490), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156509), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158218), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158239));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157570), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158260));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158337), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158350));
							ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156518), c3111dbd73271125c26adeed3dddb6f2f.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157590), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158385));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158583), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158616));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158645), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158660));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158787), text3);
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158800), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158831));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158856), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158887));
							ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157644), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157683));
							c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
							c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, text);
							byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
							c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(sslStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20832), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
							cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(sslStream);
							int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20836);
							int num2;
							do
							{
								num2 = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(sslStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20840), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
								text4 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text4, c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20844), num2));
								if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149328)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20848))
								{
									while (true)
									{
										switch (1)
										{
										case 0:
											continue;
										}
										break;
									}
									int num3 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149328));
									int num4 = ce02f80c58d177f6269598f2b1d9425bd.c30767ddca1f9c207888833aea5b5fc61(text4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337), num3 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20852));
									string text5 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text4, num3 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20856), num4 - (num3 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20860)));
									c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text5, ref num);
									int num5 = num4 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20864);
									int num6 = c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text4);
									if (num == num6 - num5 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20868))
									{
										while (true)
										{
											switch (7)
											{
											case 0:
												continue;
											}
											break;
										}
										num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20872);
									}
								}
							}
							while (num2 != 0);
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						finally
						{
							if (sslStream != null)
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sslStream);
							}
						}
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
				ced67d0527f85483071a0086e7d3ef52e ced67d0527f85483071a0086e7d3ef52e = new ced67d0527f85483071a0086e7d3ef52e(text4);
				try
				{
					StreamReader streamReader = cf2ae6da201b2402266aad1d4824076e7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c19c69889355b14ea1c60d173f82431b1.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e));
					try
					{
						string text6 = c826b756047d7eec56cd86b5698fcdad2.c30767ddca1f9c207888833aea5b5fc61(streamReader);
						result = this.c4017b48edd5871efb1563c699df02bd9(text6, c41303f5801b83831668dac7d66691e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20876) != 0);
					}
					finally
					{
						if (streamReader != null)
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(streamReader);
						}
					}
				}
				finally
				{
					if (ced67d0527f85483071a0086e7d3ef52e != null)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				this.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157750)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20880) != 0);
			}
			return result;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000625A4 File Offset: 0x000607A4
		private bool c482aa30397ad6ceec1a3b39772286af3(string text, c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e)
		{
			bool result;
			try
			{
				string text2 = "";
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text);
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20884));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20888), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20892), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20896));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_6B_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c482aa30397ad6ceec1a3b39772286af3(string, c41303f5801b83831668dac7d66691e12)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20900));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20904) != 0);
							return result;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20908)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (6)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20912));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20916));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate75 == null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate75 = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.c550e7728c28be11fb16fabeb19d9944f);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate75);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						SslStream sslStream = c76dddf1520614371110b313df8c1ced9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(networkStream, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20920) != 0, new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.c122c43a3e5a31be8efbbf95676824fac), caacaf1de8ee5efc5c5ff8d3ff3f48a17.c8a754f5f2ca4adde825691a9c31a0e83);
						try
						{
							c11d64e6f23e2972bb40d6fb8bdfe67ea.c30767ddca1f9c207888833aea5b5fc61(sslStream, cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
							ce4341ddc100347512b84287c8827f1c0.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157490), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156509), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157570), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157583));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157590), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157611));
							c754f24df46b158c44830579413083dd5.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158916), c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20924)));
							ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157644), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158955));
							c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
							byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
							c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(sslStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20928), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
							cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(sslStream);
							int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20932);
							int num2;
							do
							{
								num2 = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(sslStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20936), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
								text2 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20940), num2));
								if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149328)) != 0)
								{
									while (true)
									{
										switch (3)
										{
										case 0:
											continue;
										}
										break;
									}
									if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20944))
									{
										while (true)
										{
											switch (4)
											{
											case 0:
												continue;
											}
											break;
										}
										int num3 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20948);
										int num4 = ce02f80c58d177f6269598f2b1d9425bd.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337), cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20952));
										string text3 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text2, num3, num4 - num3);
										num = c606fafaa600fdd723e91114a8f450cda.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text3);
									}
									else if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156671)) == 0)
									{
										while (true)
										{
											switch (6)
											{
											case 0:
												continue;
											}
											break;
										}
										num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20956);
									}
									if (num != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20960))
									{
										while (true)
										{
											switch (4)
											{
											case 0:
												continue;
											}
											break;
										}
										int num5 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149328));
										int num6 = c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text2);
										if (num == num6 - num5 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20964))
										{
											while (true)
											{
												switch (3)
												{
												case 0:
													continue;
												}
												break;
											}
											num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20968);
										}
									}
								}
							}
							while (num2 != 0);
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						finally
						{
							if (sslStream != null)
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sslStream);
							}
						}
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
				ced67d0527f85483071a0086e7d3ef52e ced67d0527f85483071a0086e7d3ef52e = new ced67d0527f85483071a0086e7d3ef52e(text2);
				try
				{
					if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159038)) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20972))
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						int num7 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159038)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20976);
						int num8 = ce02f80c58d177f6269598f2b1d9425bd.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159073), cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159038)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20980));
						c41303f5801b83831668dac7d66691e.c8f2edca2205ab5c12cc2807d07b62388 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text2, num7, num8 - num7);
					}
					if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159076)) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20984))
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						int num9 = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159076)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20988);
						int num10 = ce02f80c58d177f6269598f2b1d9425bd.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159073), cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159076)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20992));
						c41303f5801b83831668dac7d66691e.caa2d46573a9e7a04d40a650c4f6951dc = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text2, num9, num10 - num9);
					}
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(20996) != 0);
				}
				finally
				{
					if (ced67d0527f85483071a0086e7d3ef52e != null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				this.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157750)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21000) != 0);
			}
			return result;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00062CD8 File Offset: 0x00060ED8
		private string cedb7dc066481dba6ce06ac57d60e9973(XAttribute xAttribute)
		{
			if (xAttribute == null)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_15_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.cedb7dc066481dba6ce06ac57d60e9973(XAttribute)).MethodHandle;
				}
				return string.Empty;
			}
			return cd5d7393ab0dc290fe1642ec029c175ac.c30767ddca1f9c207888833aea5b5fc61(xAttribute);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00062D0C File Offset: 0x00060F0C
		private bool c7706c5496c55fcaef4e39266f0529a16(string text, string text2, c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e, string text3)
		{
			bool result;
			try
			{
				string text4 = "";
				StringBuilder stringBuilder = c3fcb87fc3bfa2408c9c2d857dd3c1c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Uri uri = c51c7effe6bbd175b8bf582917856fc58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2);
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21004));
				c7726724dac34cb3ce4268099f7ee4ca1 c7726724dac34cb3ce4268099f7ee4ca = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21008), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21012), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21016));
				try
				{
					if (c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 != null)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_6B_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c7706c5496c55fcaef4e39266f0529a16(string, string, c41303f5801b83831668dac7d66691e12, string)).MethodHandle;
						}
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21020));
						IPAddress[] array2 = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cde98427214599064c58cb5a4de8ecc6b);
						if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array2) == 0)
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21024) != 0);
							return result;
						}
						c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21028)], (int)c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cadb0be687ce11e2be1869999f35a7141));
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6, ""))
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104, ""))
							{
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									break;
								}
								c7726724dac34cb3ce4268099f7ee4ca.set_c77f6d5110881e0ded8ecd7133324227a(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.cb5466a044809fda944eb67b4c5d2c8f6);
								c7726724dac34cb3ce4268099f7ee4ca.set_c451994856b7e775630c666d59938ad1c(c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283.caee1e47a08a4ecec009fb2516f979104);
							}
						}
					}
					else
					{
						c7726724dac34cb3ce4268099f7ee4ca.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21032));
					}
					c7726724dac34cb3ce4268099f7ee4ca.c963205f48624dc045b80d2b8b74f89b9(cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21036));
					if (cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate77 == null)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate77 = new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.cf9e00ae14a414ce3aab5c684e8417f41);
					}
					cae182cfed846011c99c6a21d65f58109.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbf4111912aed594f2b4372828dd95aa3.CS$<>9__CachedAnonymousMethodDelegate77);
					NetworkStream networkStream = c9883671109bd50ccbd6866c2590165b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7726724dac34cb3ce4268099f7ee4ca);
					try
					{
						SslStream sslStream = c76dddf1520614371110b313df8c1ced9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(networkStream, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21040) != 0, new RemoteCertificateValidationCallback(cbf4111912aed594f2b4372828dd95aa3.c122c43a3e5a31be8efbbf95676824fac), caacaf1de8ee5efc5c5ff8d3ff3f48a17.c8a754f5f2ca4adde825691a9c31a0e83);
						try
						{
							c11d64e6f23e2972bb40d6fb8bdfe67ea.c30767ddca1f9c207888833aea5b5fc61(sslStream, cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
							ce4341ddc100347512b84287c8827f1c0.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157490), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156509), cdfc2dee882bbc9e63956b3ee921c8722.c30767ddca1f9c207888833aea5b5fc61(uri), cab9cd1708e34fc6fb9927877079b78aa.c30767ddca1f9c207888833aea5b5fc61(uri));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158218), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158239));
							ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156518), c3111dbd73271125c26adeed3dddb6f2f.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159105), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159132));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157570), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159151));
							ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157644), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157683));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158337), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158350));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157590), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158385));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158645), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159301));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158800), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158831));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158856), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158887));
							c15cef68afb0b68b0468dca4c697c37a7.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(158787), text3);
							c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337));
							c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, text);
							byte[] array3 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
							c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(sslStream, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21044), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
							cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(sslStream);
							int num;
							do
							{
								num = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(sslStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21048), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
								text4 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text4, c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21052), num));
								if (cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149328)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21056))
								{
									while (true)
									{
										switch (5)
										{
										case 0:
											continue;
										}
										break;
									}
									num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21060);
								}
							}
							while (num != 0);
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						finally
						{
							if (sslStream != null)
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sslStream);
							}
						}
					}
					finally
					{
						if (networkStream != null)
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(networkStream);
						}
					}
				}
				finally
				{
					if (c7726724dac34cb3ce4268099f7ee4ca != null)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(c7726724dac34cb3ce4268099f7ee4ca);
					}
				}
				ced67d0527f85483071a0086e7d3ef52e ced67d0527f85483071a0086e7d3ef52e = new ced67d0527f85483071a0086e7d3ef52e(text4);
				try
				{
					StreamReader streamReader = cf2ae6da201b2402266aad1d4824076e7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c19c69889355b14ea1c60d173f82431b1.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e));
					try
					{
						c826b756047d7eec56cd86b5698fcdad2.c30767ddca1f9c207888833aea5b5fc61(streamReader);
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21064) != 0);
					}
					finally
					{
						if (streamReader != null)
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(streamReader);
						}
					}
				}
				finally
				{
					if (ced67d0527f85483071a0086e7d3ef52e != null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(ced67d0527f85483071a0086e7d3ef52e);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				this.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(157750)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21068) != 0);
			}
			return result;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00063374 File Offset: 0x00061574
		private void AutoLaunchAccount_Checked(object sender, RoutedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.AutoLaunchAccount_Checked(object, RoutedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			cd4d5a5684d153eefc4ebe1d89a85e677 arg_78_0 = accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430;
			bool? flag = ccbea4253e9b7a3696e50409b304aa41f.c30767ddca1f9c207888833aea5b5fc61(cb692bee7a0880af3cd79606ff4232aa6.cea69e7c4d1a729bd5783221de1566e79(sender));
			arg_78_0.ccb2c415213d47537af44476338eb3e7e = cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag);
			bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21072) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag2);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21076) != 0);
			}
			finally
			{
				if (flag2)
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00063450 File Offset: 0x00061650
		private void AutoEnterGameWorld_Checked(object sender, RoutedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.AutoEnterGameWorld_Checked(object, RoutedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			cd4d5a5684d153eefc4ebe1d89a85e677 arg_78_0 = accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430;
			bool? flag = ccbea4253e9b7a3696e50409b304aa41f.c30767ddca1f9c207888833aea5b5fc61(cb692bee7a0880af3cd79606ff4232aa6.cea69e7c4d1a729bd5783221de1566e79(sender));
			arg_78_0.c2a8aa71ce33e714c20c130e630219584 = cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag);
			bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21080) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag2);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21084) != 0);
			}
			finally
			{
				if (flag2)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0006352C File Offset: 0x0006172C
		private void NewToolStripButtonScheduler_Click(object sender, RoutedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.NewToolStripButtonScheduler_Click(object, RoutedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			int cb5905b594e11dea2f73932df = this.ca363176affcc7719c87ca60ddb5f6f34.c4f2a6778c0f37f1aed01a00ba2b8796f(accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb5905b594e11dea2f73932df05981674);
			cc401045b2d3a107c5397ce08b50b21f0 cc401045b2d3a107c5397ce08b50b21f = new cc401045b2d3a107c5397ce08b50b21f0();
			cc401045b2d3a107c5397ce08b50b21f.cb5905b594e11dea2f73932df05981674 = cb5905b594e11dea2f73932df;
			cc401045b2d3a107c5397ce08b50b21f.ce218493b1293e8c48cc7f36933a6932e = accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb5905b594e11dea2f73932df05981674;
			object expr_96 = cceb8b6cda797b5d3dd47c135717cf0a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			SchedulerInfo schedulerInfo = c22853cb1a2cc8a74af890760bcb782be.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			c3b1387bfefb4ab72d330e2d04ff7a5b9.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, this.ca363176affcc7719c87ca60ddb5f6f34);
			ced62e28aa9ec991708c915e85c294a03.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, cc401045b2d3a107c5397ce08b50b21f);
			cfe84b5ba766529a8b76bd47c7afc040f.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, cc401045b2d3a107c5397ce08b50b21f.c60c0eb2e26a4f9af0ed98ae796effea1);
			c5c8f67f2258478e63d20858b8d96d768.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c3980231756d98f77b332e12a7eea1cf0.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86), cc401045b2d3a107c5397ce08b50b21f.c3ec335a884e0e805a58881f2832c8af0)));
			c84c669949e419ff908bc018fcbddbf8b.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c0698629fc08d683fc1fe8d82ce5e8fda(cc401045b2d3a107c5397ce08b50b21f.c04f3a1ba94cd5bf5ae9908d00de8f369), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154353), this.c0698629fc08d683fc1fe8d82ce5e8fda(cc401045b2d3a107c5397ce08b50b21f.cda9f7f94b127e0b9c034e056d128a2a6)));
			cf72024de6a3187d76f598dccb41cb0db.c30767ddca1f9c207888833aea5b5fc61(expr_96, schedulerInfo);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0006365C File Offset: 0x0006185C
		private void DeleteToolStripButtonScheduler_Click(object sender, RoutedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.DeleteToolStripButtonScheduler_Click(object, RoutedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7);
			if (c4f494e60fea81956c5b4a29993852625.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68) == null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			SchedulerInfo schedulerInfo = cf7d37206ae0418ab99a111709550887a.cea69e7c4d1a729bd5783221de1566e79(c4f494e60fea81956c5b4a29993852625.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68));
			c5ed216d67b3445705ebfedc8a5d5d6bd.c30767ddca1f9c207888833aea5b5fc61(cceb8b6cda797b5d3dd47c135717cf0a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), schedulerInfo);
			this.ca363176affcc7719c87ca60ddb5f6f34.c46843ec4ace78ca7beb35e7f1c344845(c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo).cb5905b594e11dea2f73932df05981674);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00063714 File Offset: 0x00061914
		private void ExportToCSVButton_Click(object sender, RoutedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ExportToCSVButton_Click(object, RoutedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			SaveFileDialog saveFileDialog = c75b92b4605d548d1a7bc3d92c66ba6d6.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			caf3f6fde759bf8588af13067b1537ec2.c30767ddca1f9c207888833aea5b5fc61(saveFileDialog, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153754));
			c4208d1ead8aba9af768229617f3d1a31.c30767ddca1f9c207888833aea5b5fc61(saveFileDialog, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21088));
			c61521f76d769e0abddc65d6e14f31ad7.c30767ddca1f9c207888833aea5b5fc61(saveFileDialog, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21092) != 0);
			if (cfd96c11a4b731b6425b00551c0f24764.c30767ddca1f9c207888833aea5b5fc61(saveFileDialog) == (DialogResult)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21096))
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				string text = c937b26b91edf22459746372744691625.c30767ddca1f9c207888833aea5b5fc61(saveFileDialog);
				if (cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text))
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					this.c8299fa31317d146976f1ea9cd623369b(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153841), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				}
				if (!c49b76edf1940c188fa37efd6d026df37.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153892)))
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					text = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153892));
				}
				if (this.ca363176affcc7719c87ca60ddb5f6f34.ce8e08c69670826dcab67d9f1800b87ba(text, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb5905b594e11dea2f73932df05981674))
				{
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					this.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159426), text), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				}
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00063890 File Offset: 0x00061A90
		private void ImportFromCSVButton_Click(object sender, RoutedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ImportFromCSVButton_Click(object, RoutedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			OpenFileDialog openFileDialog = c357ebbb966876dcc8012637ac2b20145.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			caf3f6fde759bf8588af13067b1537ec2.c30767ddca1f9c207888833aea5b5fc61(openFileDialog, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153754));
			c4208d1ead8aba9af768229617f3d1a31.c30767ddca1f9c207888833aea5b5fc61(openFileDialog, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21100));
			c61521f76d769e0abddc65d6e14f31ad7.c30767ddca1f9c207888833aea5b5fc61(openFileDialog, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21104) != 0);
			if (cfd96c11a4b731b6425b00551c0f24764.c30767ddca1f9c207888833aea5b5fc61(openFileDialog) == (DialogResult)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21108))
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				string text = c937b26b91edf22459746372744691625.c30767ddca1f9c207888833aea5b5fc61(openFileDialog);
				if (cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text))
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					this.c8299fa31317d146976f1ea9cd623369b(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154030), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				}
				if (!c49b76edf1940c188fa37efd6d026df37.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153892)))
				{
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					text = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153892));
				}
				if (this.ca4b8b6ed594ffd1379f443533c23147f(text, accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb5905b594e11dea2f73932df05981674))
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					this.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159483), text), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
					return;
				}
				this.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159544), text), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00063A30 File Offset: 0x00061C30
		private bool ca4b8b6ed594ffd1379f443533c23147f(string text, int num)
		{
			try
			{
				TextFieldParser textFieldParser = cf0574f4c1fa880959b236ed6820d249e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text);
				c762d32ade7b60f1e69d3c43501c14fba.c30767ddca1f9c207888833aea5b5fc61(textFieldParser, (FieldType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21112));
				object arg_48_0 = textFieldParser;
				string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21116));
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21120)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(122007);
				c95842c98c68d70e4ffbab62d5ed52ce8.c30767ddca1f9c207888833aea5b5fc61(arg_48_0, array);
				int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21124);
				bool result;
				while (!c49a2cb85de35633b798895b5851eeef9.c30767ddca1f9c207888833aea5b5fc61(textFieldParser))
				{
					List<string> list = c730f27d5c8997ea3da3b8bf80c859424.c30767ddca1f9c207888833aea5b5fc61(textFieldParser).ToList<string>();
					if (c917285c46e176f472f1c2753bdd49aab.c30767ddca1f9c207888833aea5b5fc61(list) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21128))
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_93_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.ca4b8b6ed594ffd1379f443533c23147f(string, int)).MethodHandle;
						}
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21132) != 0);
						return result;
					}
					string text2 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21136));
					string text3 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21140));
					string text4 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21144));
					string text5 = c384e4a89e4e03c57921d9891745e90b6.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21148));
					num2 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21152);
					if (num2 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21156))
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2))
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							if (!cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text3))
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								if (!cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text4))
								{
									while (true)
									{
										switch (4)
										{
										case 0:
											continue;
										}
										break;
									}
									if (!cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text5))
									{
										while (true)
										{
											switch (1)
											{
											case 0:
												continue;
											}
											break;
										}
										int num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21160);
										int num4 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21164);
										int num5 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21168);
										c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text3, ref num3);
										if (this.c1e589ac84f528506f6ed36a40e2aa928(text4))
										{
											while (true)
											{
												switch (1)
												{
												case 0:
													continue;
												}
												break;
											}
											object expr_1CA = c359af69556ed29c26d038f41f9b5b13d.c30767ddca1f9c207888833aea5b5fc61(text4);
											string[] array2 = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21172));
											array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21176)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
											string[] array3 = cc19ced84c86a267bd615bafbf2c5917a.c30767ddca1f9c207888833aea5b5fc61(expr_1CA, array2, (StringSplitOptions)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21180));
											int num6 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21184);
											int num7 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21188);
											if ((int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array3) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21192))
											{
												while (true)
												{
													switch (4)
													{
													case 0:
														continue;
													}
													break;
												}
												if (c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21196)], ref num6))
												{
													while (true)
													{
														switch (2)
														{
														case 0:
															continue;
														}
														break;
													}
													if (c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21200)], ref num7))
													{
														while (true)
														{
															switch (3)
															{
															case 0:
																continue;
															}
															break;
														}
														num4 = num7 + num6 * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21204);
													}
												}
											}
										}
										if (this.c1e589ac84f528506f6ed36a40e2aa928(text5))
										{
											while (true)
											{
												switch (7)
												{
												case 0:
													continue;
												}
												break;
											}
											object expr_2BB = c359af69556ed29c26d038f41f9b5b13d.c30767ddca1f9c207888833aea5b5fc61(text5);
											string[] array4 = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21208));
											array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21212)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
											string[] array5 = cc19ced84c86a267bd615bafbf2c5917a.c30767ddca1f9c207888833aea5b5fc61(expr_2BB, array4, (StringSplitOptions)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21216));
											int num8 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21220);
											int num9 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21224);
											if ((int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array5) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21228))
											{
												while (true)
												{
													switch (3)
													{
													case 0:
														continue;
													}
													break;
												}
												if (c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21232)], ref num8))
												{
													while (true)
													{
														switch (1)
														{
														case 0:
															continue;
														}
														break;
													}
													if (c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21236)], ref num9))
													{
														while (true)
														{
															switch (1)
															{
															case 0:
																continue;
															}
															break;
														}
														num5 = num9 + num8 * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21240);
													}
												}
											}
										}
										if (!this.ca363176affcc7719c87ca60ddb5f6f34.c5bb7cb25494f858660a51258f01425c7(num, num3, num4, num5))
										{
											while (true)
											{
												switch (6)
												{
												case 0:
													continue;
												}
												break;
											}
											int cb5905b594e11dea2f73932df = this.ca363176affcc7719c87ca60ddb5f6f34.c4f2a6778c0f37f1aed01a00ba2b8796f(num);
											cc401045b2d3a107c5397ce08b50b21f0 cc401045b2d3a107c5397ce08b50b21f = new cc401045b2d3a107c5397ce08b50b21f0();
											cc401045b2d3a107c5397ce08b50b21f.cb5905b594e11dea2f73932df05981674 = cb5905b594e11dea2f73932df;
											cc401045b2d3a107c5397ce08b50b21f.ce218493b1293e8c48cc7f36933a6932e = num;
											SchedulerInfo schedulerInfo = c22853cb1a2cc8a74af890760bcb782be.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
											c3b1387bfefb4ab72d330e2d04ff7a5b9.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, this.ca363176affcc7719c87ca60ddb5f6f34);
											ced62e28aa9ec991708c915e85c294a03.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, cc401045b2d3a107c5397ce08b50b21f);
											SchedulerInfo schedulerInfo2 = schedulerInfo;
											c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo2).c60c0eb2e26a4f9af0ed98ae796effea1 = c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(36724));
											cfe84b5ba766529a8b76bd47c7afc040f.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo2, c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo2).c60c0eb2e26a4f9af0ed98ae796effea1);
											c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo2).c3ec335a884e0e805a58881f2832c8af0 = num3;
											c5c8f67f2258478e63d20858b8d96d768.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo2, cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c3980231756d98f77b332e12a7eea1cf0.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86), num3)));
											c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo2).c04f3a1ba94cd5bf5ae9908d00de8f369 = num4;
											c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo2).cda9f7f94b127e0b9c034e056d128a2a6 = num5;
											c84c669949e419ff908bc018fcbddbf8b.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo2, c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c0698629fc08d683fc1fe8d82ce5e8fda(c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo2).c04f3a1ba94cd5bf5ae9908d00de8f369), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154353), this.c0698629fc08d683fc1fe8d82ce5e8fda(c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo2).cda9f7f94b127e0b9c034e056d128a2a6)));
											using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(schedulerInfo2.c88bb72e11f2edffb262d6c1220a86abe))
											{
												c8161a528556ca1d1883ca15bd98c545a.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21244) != 0);
											}
											cf72024de6a3187d76f598dccb41cb0db.c30767ddca1f9c207888833aea5b5fc61(cceb8b6cda797b5d3dd47c135717cf0a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), schedulerInfo2);
											this.c8299fa31317d146976f1ea9cd623369b(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159631), num2 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21248), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159648)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
										}
										else
										{
											this.c8299fa31317d146976f1ea9cd623369b(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159631), num2 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21252), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159695)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
										}
									}
								}
							}
						}
					}
				}
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				c8eb3a83832ce6b5645631aad5b3eefd1.c30767ddca1f9c207888833aea5b5fc61(textFieldParser);
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21256) != 0);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21260) != 0;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0006404C File Offset: 0x0006224C
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (!ccb3a37e39f5cb9245628b004349eac73.c30767ddca1f9c207888833aea5b5fc61(AppMain.c268f1b1716725102a4850ddda960c420))
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_20_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.Button_Click(object, RoutedEventArgs)).MethodHandle;
				}
				cd42d36dd6f379099183ebe4983e29d89.c30767ddca1f9c207888833aea5b5fc61(AppMain.c268f1b1716725102a4850ddda960c420);
			}
			c87e60912a770e037fc3394d900687990.c30767ddca1f9c207888833aea5b5fc61(AppMain.c268f1b1716725102a4850ddda960c420);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00064094 File Offset: 0x00062294
		private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
		{
			cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159728), cc4987d6a853db77954f21abe4e42946a.c87dc00533dbed281d546bf1a305efa0b));
			cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(36900)));
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x000640DC File Offset: 0x000622DC
		private void clientLangSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.clientLangSelectionChanged(object, SelectionChangedEventArgs)).MethodHandle;
				}
				return;
			}
			if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(cc5ba717e158effd00e766e2a1f120307.cea69e7c4d1a729bd5783221de1566e79(sender)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21264))
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cb985061242b7c893cd2fde331e41a62a = c2b2703f8d5dda9c922e7b8a4df1cb1df.cea69e7c4d1a729bd5783221de1566e79(c0aa5b3e2cfcc489c6946a5bd3b9f4e52.c30767ddca1f9c207888833aea5b5fc61(cf351bf17b7cf14712eb4d1f631c937a4.cea69e7c4d1a729bd5783221de1566e79(c63eec5f5fa5b955ae3efb28da0d563e1.c30767ddca1f9c207888833aea5b5fc61(cccc4e141f0000245fdf2ebb12de1a445.c30767ddca1f9c207888833aea5b5fc61(e), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21268)))));
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21272) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21276) != 0);
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x000641F4 File Offset: 0x000623F4
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.Button_Click_1(object, RoutedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			if (accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9 != null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				List<c6bdd46ef9f05485f6b69f34bf6920a88>.Enumerator enumerator = c6db869dc720a296d6436877fc6038006.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.cb9213ffba9d183be8ba376e0677c9488);
				try
				{
					while (cc0c0e5206fa0bd9fbc48103d2a9d32b0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator))
					{
						c6bdd46ef9f05485f6b69f34bf6920a88 c6bdd46ef9f05485f6b69f34bf6920a = cf6234b09690116f4a2a0213e5bae23e8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator);
						accTreeViewInfo.ca124a9f406cda69b904f2eb04d553ab9.c1d09e0a08f3e2b4cbf6d6b4d4c4c088c(c6bdd46ef9f05485f6b69f34bf6920a);
					}
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000642CC File Offset: 0x000624CC
		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.Button_Click_2(object, RoutedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			AccTreeViewInfo accTreeViewInfo2 = c2aa93f14f02daf7434a6dc4f4f6c363a.c8a754f5f2ca4adde825691a9c31a0e83;
			if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c88aaa8af9bfe41a2300eab3d3ccb64f9())
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				IEnumerator<AccTreeViewInfo> enumerator = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b);
				try
				{
					while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
					{
						AccTreeViewInfo accTreeViewInfo3 = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator);
						if (c8b792a9ba0aee1bacc58fdcdb96fcd57.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo3) == Visibility.Visible)
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							if (accTreeViewInfo3.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac > accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac)
							{
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
								if (accTreeViewInfo2 == null)
								{
									while (true)
									{
										switch (7)
										{
										case 0:
											continue;
										}
										break;
									}
									accTreeViewInfo2 = accTreeViewInfo3;
								}
								else if (accTreeViewInfo3.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac < accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac)
								{
									while (true)
									{
										switch (2)
										{
										case 0:
											continue;
										}
										break;
									}
									accTreeViewInfo2 = accTreeViewInfo3;
								}
							}
						}
					}
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					goto IL_306;
				}
				finally
				{
					if (enumerator != null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
					}
				}
			}
			ServerTreeViewInfo serverTreeViewInfo = c2733fee0206336a7fb39d68bc0ae5507.c8a754f5f2ca4adde825691a9c31a0e83;
			IEnumerator<WorldTreeViewInfo> enumerator2 = c64aaef4a72b1cca6cf3b8e689c30656c.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e);
			try
			{
				while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator2))
				{
					WorldTreeViewInfo worldTreeViewInfo = c6cb3068dd1dba97b102455710cf6a79f.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
					IEnumerator<ServerTreeViewInfo> enumerator3 = c266116c92138d153032ef71f5e63e4fc.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(worldTreeViewInfo));
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator3))
						{
							ServerTreeViewInfo serverTreeViewInfo2 = c6ab76f0df3a33e553b2cfe7c47b9f13b.c30767ddca1f9c207888833aea5b5fc61(enumerator3);
							IEnumerator<AccTreeViewInfo> enumerator4 = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo2));
							try
							{
								while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator4))
								{
									AccTreeViewInfo accTreeViewInfo4 = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator4);
									if (accTreeViewInfo4 == accTreeViewInfo)
									{
										while (true)
										{
											switch (3)
											{
											case 0:
												continue;
											}
											break;
										}
										serverTreeViewInfo = serverTreeViewInfo2;
									}
								}
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
							}
							finally
							{
								if (enumerator4 != null)
								{
									while (true)
									{
										switch (3)
										{
										case 0:
											continue;
										}
										break;
									}
									cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator4);
								}
							}
						}
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					finally
					{
						if (enumerator3 != null)
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator3);
						}
					}
				}
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			finally
			{
				if (enumerator2 != null)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
				}
			}
			if (serverTreeViewInfo != null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				IEnumerator<AccTreeViewInfo> enumerator5 = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo));
				try
				{
					while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator5))
					{
						AccTreeViewInfo accTreeViewInfo5 = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator5);
						if (c8b792a9ba0aee1bacc58fdcdb96fcd57.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo5) == Visibility.Visible)
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							if (accTreeViewInfo5.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac > accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac)
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								if (accTreeViewInfo2 == null)
								{
									while (true)
									{
										switch (7)
										{
										case 0:
											continue;
										}
										break;
									}
									accTreeViewInfo2 = accTreeViewInfo5;
								}
								else if (accTreeViewInfo5.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac < accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac)
								{
									while (true)
									{
										switch (2)
										{
										case 0:
											continue;
										}
										break;
									}
									accTreeViewInfo2 = accTreeViewInfo5;
								}
							}
						}
					}
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				finally
				{
					if (enumerator5 != null)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator5);
					}
				}
			}
			IL_306:
			if (accTreeViewInfo2 != null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				int cfe2402a851c8636a5550251320efc6ac = accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac;
				accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac = accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac;
				accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac = cfe2402a851c8636a5550251320efc6ac;
				bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21280) != 0;
				try
				{
					object cdb456cfdfb988429e8ab93cb585f031e;
					cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
					accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21284) != 0);
				}
				finally
				{
					if (flag)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						object cdb456cfdfb988429e8ab93cb585f031e;
						c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
					}
				}
				bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21288) != 0;
				try
				{
					object cdb456cfdfb988429e8ab93cb585f031e2;
					cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e2 = accTreeViewInfo2.cdb456cfdfb988429e8ab93cb585f031e, ref flag2);
					accTreeViewInfo2.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21292) != 0);
				}
				finally
				{
					if (flag2)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						object cdb456cfdfb988429e8ab93cb585f031e2;
						c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e2);
					}
				}
				this.c5e187df5cedd5db95e3b28da96f32763();
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00064708 File Offset: 0x00062908
		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.Button_Click_3(object, RoutedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			AccTreeViewInfo accTreeViewInfo2 = c2aa93f14f02daf7434a6dc4f4f6c363a.c8a754f5f2ca4adde825691a9c31a0e83;
			if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c88aaa8af9bfe41a2300eab3d3ccb64f9())
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				IEnumerator<AccTreeViewInfo> enumerator = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(this.cd559d791bccc45933a81e7e47e42fd1b);
				try
				{
					while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
					{
						AccTreeViewInfo accTreeViewInfo3 = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator);
						if (c8b792a9ba0aee1bacc58fdcdb96fcd57.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo3) == Visibility.Visible)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							if (accTreeViewInfo3.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac < accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac)
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								if (accTreeViewInfo2 == null)
								{
									while (true)
									{
										switch (4)
										{
										case 0:
											continue;
										}
										break;
									}
									accTreeViewInfo2 = accTreeViewInfo3;
								}
								else if (accTreeViewInfo3.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac > accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac)
								{
									while (true)
									{
										switch (5)
										{
										case 0:
											continue;
										}
										break;
									}
									accTreeViewInfo2 = accTreeViewInfo3;
								}
							}
						}
					}
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					goto IL_306;
				}
				finally
				{
					if (enumerator != null)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
					}
				}
			}
			ServerTreeViewInfo serverTreeViewInfo = c2733fee0206336a7fb39d68bc0ae5507.c8a754f5f2ca4adde825691a9c31a0e83;
			IEnumerator<WorldTreeViewInfo> enumerator2 = c64aaef4a72b1cca6cf3b8e689c30656c.c30767ddca1f9c207888833aea5b5fc61(this.c4fc5dab2c31ad3f0faa92b746c49837e);
			try
			{
				while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator2))
				{
					WorldTreeViewInfo worldTreeViewInfo = c6cb3068dd1dba97b102455710cf6a79f.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
					IEnumerator<ServerTreeViewInfo> enumerator3 = c266116c92138d153032ef71f5e63e4fc.c30767ddca1f9c207888833aea5b5fc61(c52a641cc61f2c810da887600b453fbae.c30767ddca1f9c207888833aea5b5fc61(worldTreeViewInfo));
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator3))
						{
							ServerTreeViewInfo serverTreeViewInfo2 = c6ab76f0df3a33e553b2cfe7c47b9f13b.c30767ddca1f9c207888833aea5b5fc61(enumerator3);
							IEnumerator<AccTreeViewInfo> enumerator4 = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo2));
							try
							{
								while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator4))
								{
									AccTreeViewInfo accTreeViewInfo4 = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator4);
									if (accTreeViewInfo4 == accTreeViewInfo)
									{
										while (true)
										{
											switch (2)
											{
											case 0:
												continue;
											}
											break;
										}
										serverTreeViewInfo = serverTreeViewInfo2;
									}
								}
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
							}
							finally
							{
								if (enumerator4 != null)
								{
									while (true)
									{
										switch (3)
										{
										case 0:
											continue;
										}
										break;
									}
									cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator4);
								}
							}
						}
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					finally
					{
						if (enumerator3 != null)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator3);
						}
					}
				}
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			finally
			{
				if (enumerator2 != null)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
				}
			}
			if (serverTreeViewInfo != null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				IEnumerator<AccTreeViewInfo> enumerator5 = cf4a8f6ff163f68af3e5801234e9ca4f9.c30767ddca1f9c207888833aea5b5fc61(c714fc5b60c1f700ce8ad82a86841a81d.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo));
				try
				{
					while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator5))
					{
						AccTreeViewInfo accTreeViewInfo5 = caabe9ecca6c0d7c171f708b89c942aa5.c30767ddca1f9c207888833aea5b5fc61(enumerator5);
						if (c8b792a9ba0aee1bacc58fdcdb96fcd57.c30767ddca1f9c207888833aea5b5fc61(accTreeViewInfo5) == Visibility.Visible)
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							if (accTreeViewInfo5.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac < accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac)
							{
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
								if (accTreeViewInfo2 == null)
								{
									while (true)
									{
										switch (2)
										{
										case 0:
											continue;
										}
										break;
									}
									accTreeViewInfo2 = accTreeViewInfo5;
								}
								else if (accTreeViewInfo5.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac > accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac)
								{
									while (true)
									{
										switch (7)
										{
										case 0:
											continue;
										}
										break;
									}
									accTreeViewInfo2 = accTreeViewInfo5;
								}
							}
						}
					}
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				finally
				{
					if (enumerator5 != null)
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator5);
					}
				}
			}
			IL_306:
			if (accTreeViewInfo2 != null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				int cfe2402a851c8636a5550251320efc6ac = accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac;
				accTreeViewInfo2.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac = accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac;
				accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac = cfe2402a851c8636a5550251320efc6ac;
				bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21296) != 0;
				try
				{
					object cdb456cfdfb988429e8ab93cb585f031e;
					cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag);
					accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21300) != 0);
				}
				finally
				{
					if (flag)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						object cdb456cfdfb988429e8ab93cb585f031e;
						c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
					}
				}
				bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21304) != 0;
				try
				{
					object cdb456cfdfb988429e8ab93cb585f031e2;
					cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e2 = accTreeViewInfo2.cdb456cfdfb988429e8ab93cb585f031e, ref flag2);
					accTreeViewInfo2.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21308) != 0);
				}
				finally
				{
					if (flag2)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						object cdb456cfdfb988429e8ab93cb585f031e2;
						c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e2);
					}
				}
				this.c5e187df5cedd5db95e3b28da96f32763();
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00064B44 File Offset: 0x00062D44
		private void DayOfTheWeek_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (c4f494e60fea81956c5b4a29993852625.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68) == null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.DayOfTheWeek_SelectionChanged(object, SelectionChangedEventArgs)).MethodHandle;
				}
				return;
			}
			if (c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(cc5ba717e158effd00e766e2a1f120307.cea69e7c4d1a729bd5783221de1566e79(sender)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21312))
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			SchedulerInfo schedulerInfo = cf7d37206ae0418ab99a111709550887a.cea69e7c4d1a729bd5783221de1566e79(c4f494e60fea81956c5b4a29993852625.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68));
			c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo).c3ec335a884e0e805a58881f2832c8af0 = c294f1d01d21813b87eda519eebde6add.c30767ddca1f9c207888833aea5b5fc61(cc5ba717e158effd00e766e2a1f120307.cea69e7c4d1a729bd5783221de1566e79(sender));
			c5c8f67f2258478e63d20858b8d96d768.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c4f494e60fea81956c5b4a29993852625.c30767ddca1f9c207888833aea5b5fc61(cc5ba717e158effd00e766e2a1f120307.cea69e7c4d1a729bd5783221de1566e79(sender))));
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(schedulerInfo.c88bb72e11f2edffb262d6c1220a86abe))
			{
				c8161a528556ca1d1883ca15bd98c545a.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21316) != 0);
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00064C28 File Offset: 0x00062E28
		private void TimeFrom_TextChanged(object sender, TextChangedEventArgs e)
		{
			try
			{
				if (c4f494e60fea81956c5b4a29993852625.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68) == null)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.TimeFrom_TextChanged(object, TextChangedEventArgs)).MethodHandle;
					}
				}
				else
				{
					SchedulerInfo schedulerInfo = cf7d37206ae0418ab99a111709550887a.cea69e7c4d1a729bd5783221de1566e79(c4f494e60fea81956c5b4a29993852625.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68));
					if (this.c1e589ac84f528506f6ed36a40e2aa928(c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(c8c07d60fc8cfb7adc05a6517499994fc.cea69e7c4d1a729bd5783221de1566e79(sender))))
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						object expr_76 = c359af69556ed29c26d038f41f9b5b13d.c30767ddca1f9c207888833aea5b5fc61(c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(c8c07d60fc8cfb7adc05a6517499994fc.cea69e7c4d1a729bd5783221de1566e79(sender)));
						string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21320));
						array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21324)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
						string[] array2 = cc19ced84c86a267bd615bafbf2c5917a.c30767ddca1f9c207888833aea5b5fc61(expr_76, array, (StringSplitOptions)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21328));
						int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21332);
						int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21336);
						if ((int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array2) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21340))
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21344)], ref num))
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								if (c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21348)], ref num2))
								{
									while (true)
									{
										switch (6)
										{
										case 0:
											continue;
										}
										break;
									}
									c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo).c04f3a1ba94cd5bf5ae9908d00de8f369 = num2 + num * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21352);
									using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(schedulerInfo.c88bb72e11f2edffb262d6c1220a86abe))
									{
										c8161a528556ca1d1883ca15bd98c545a.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21356) != 0);
									}
									c84c669949e419ff908bc018fcbddbf8b.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c0698629fc08d683fc1fe8d82ce5e8fda(c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo).c04f3a1ba94cd5bf5ae9908d00de8f369), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154353), this.c0698629fc08d683fc1fe8d82ce5e8fda(c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo).cda9f7f94b127e0b9c034e056d128a2a6)));
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00064E44 File Offset: 0x00063044
		private void TimeTo_TextChanged(object sender, TextChangedEventArgs e)
		{
			try
			{
				if (c4f494e60fea81956c5b4a29993852625.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68) == null)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.TimeTo_TextChanged(object, TextChangedEventArgs)).MethodHandle;
					}
				}
				else
				{
					SchedulerInfo schedulerInfo = cf7d37206ae0418ab99a111709550887a.cea69e7c4d1a729bd5783221de1566e79(c4f494e60fea81956c5b4a29993852625.c30767ddca1f9c207888833aea5b5fc61(this.c2514f42a43aeead3c8908dc09d87fe68));
					if (this.c1e589ac84f528506f6ed36a40e2aa928(c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(c8c07d60fc8cfb7adc05a6517499994fc.cea69e7c4d1a729bd5783221de1566e79(sender))))
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						object expr_76 = c359af69556ed29c26d038f41f9b5b13d.c30767ddca1f9c207888833aea5b5fc61(c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(c8c07d60fc8cfb7adc05a6517499994fc.cea69e7c4d1a729bd5783221de1566e79(sender)));
						string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21360));
						array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21364)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
						string[] array2 = cc19ced84c86a267bd615bafbf2c5917a.c30767ddca1f9c207888833aea5b5fc61(expr_76, array, (StringSplitOptions)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21368));
						int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21372);
						int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21376);
						if ((int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array2) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21380))
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21384)], ref num))
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								if (c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21388)], ref num2))
								{
									while (true)
									{
										switch (1)
										{
										case 0:
											continue;
										}
										break;
									}
									c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo).cda9f7f94b127e0b9c034e056d128a2a6 = num2 + num * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21392);
									using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(schedulerInfo.c88bb72e11f2edffb262d6c1220a86abe))
									{
										c8161a528556ca1d1883ca15bd98c545a.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21396) != 0);
									}
									c84c669949e419ff908bc018fcbddbf8b.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo, c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c0698629fc08d683fc1fe8d82ce5e8fda(c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo).c04f3a1ba94cd5bf5ae9908d00de8f369), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154353), this.c0698629fc08d683fc1fe8d82ce5e8fda(c7853f01ea94b40c4eb896ced9491f244.c30767ddca1f9c207888833aea5b5fc61(schedulerInfo).cda9f7f94b127e0b9c034e056d128a2a6)));
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00065060 File Offset: 0x00063260
		private void EnableSchedulerForAccount_Checked(object sender, RoutedEventArgs e)
		{
			if (c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7) == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.EnableSchedulerForAccount_Checked(object, RoutedEventArgs)).MethodHandle;
				}
				return;
			}
			if (cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7)) == null)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			AccTreeViewInfo accTreeViewInfo = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7));
			cd4d5a5684d153eefc4ebe1d89a85e677 arg_76_0 = accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430;
			bool? flag = ccbea4253e9b7a3696e50409b304aa41f.c30767ddca1f9c207888833aea5b5fc61(this.c8df21b00eff0ed569413a87a911e5013);
			arg_76_0.cab09f9e913dae41dc3e871fd28b3cdae = cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag);
			bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21400) != 0;
			try
			{
				object cdb456cfdfb988429e8ab93cb585f031e;
				cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e = accTreeViewInfo.cdb456cfdfb988429e8ab93cb585f031e, ref flag2);
				accTreeViewInfo.c12116d955c4a50d0c519dc70dbd73d1f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21404) != 0);
			}
			finally
			{
				if (flag2)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					object cdb456cfdfb988429e8ab93cb585f031e;
					c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdb456cfdfb988429e8ab93cb585f031e);
				}
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00065138 File Offset: 0x00063338
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0"), DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this.caa437f4d29d724a8a6620cffc7c41e4b)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_1A_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.InitializeComponent()).MethodHandle;
				}
				return;
			}
			this.caa437f4d29d724a8a6620cffc7c41e4b = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21408) != 0);
			Uri uri = cf3ef46bf60c8113ae9f7b3989d898519.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(159785), (UriKind)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21412));
			c355752b58028a8ee1106ccbf95cb43fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, uri);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00065198 File Offset: 0x00063398
		[DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate c07dee5f578ca384f4831093fd2996518(Type type, string text)
		{
			return cbbd80cfb6a17c57e667a57b9d90293db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(type, this, text);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000651B0 File Offset: 0x000633B0
		[DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Never), GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.c1cd4642fd9ca9c41b1440b313e481c0d(int num, object obj)
		{
			switch (num - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21416))
			{
			case 0:
				cd44c44c3358a3d2e68e86233c5542941.c30767ddca1f9c207888833aea5b5fc61(c0ca594099f245e32ae98c83882cae785.c9963fcf210a214a3206d6500f3b9397b(obj), new CancelEventHandler(this.Window_Closing));
				c5fab16e03e4bf35cd546a0b19d79c12b.c30767ddca1f9c207888833aea5b5fc61(c0ca594099f245e32ae98c83882cae785.c9963fcf210a214a3206d6500f3b9397b(obj), new RoutedEventHandler(this.MetroWindow_Loaded));
				c43c186c16096275c557fec86d0835ca9.c30767ddca1f9c207888833aea5b5fc61(c0ca594099f245e32ae98c83882cae785.c9963fcf210a214a3206d6500f3b9397b(obj), new EventHandler(this.MetroWindow_Activated));
				cba8574724488e72aa1bbbddadc953d55.c30767ddca1f9c207888833aea5b5fc61(c0ca594099f245e32ae98c83882cae785.c9963fcf210a214a3206d6500f3b9397b(obj), new EventHandler(this.MetroWindow_Deactivated));
				return;
			case 1:
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj), new RoutedEventHandler(this.ConfigToolStripButton_Click));
				return;
			case 2:
				this.ce934d236e27a0409842ab9ea408c5e28 = c3268d52032f03bf24ef1948f66ae87c1.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 3:
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj), new RoutedEventHandler(this.Button_Click));
				return;
			case 4:
				this.c1597bd055f3af8220d98461ee8436c4b = c3268d52032f03bf24ef1948f66ae87c1.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 5:
				this.cb6835b9ed55a6df7200b528c72321ded = cc95903fa1c41e4f20ca4292c944606d9.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 6:
				this.c47bd676f1de5d85d70d684d663cbddd7 = c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj);
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(this.c47bd676f1de5d85d70d684d663cbddd7, new RoutedEventHandler(this.StartToolStripButton_Click));
				return;
			case 7:
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj), new RoutedEventHandler(this.StopToolStripButton_Click));
				return;
			case 8:
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj), new RoutedEventHandler(this.Button_Click_3));
				return;
			case 9:
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj), new RoutedEventHandler(this.Button_Click_2));
				return;
			case 10:
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj), new RoutedEventHandler(this.Button_Click_1));
				return;
			case 11:
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj), new RoutedEventHandler(this.NewToolStripButton_Click));
				return;
			case 12:
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj), new RoutedEventHandler(this.DeleteToolStripButton_Click));
				return;
			case 13:
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj), new RoutedEventHandler(this.ExportToExcelButton_Click));
				return;
			case 14:
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj), new RoutedEventHandler(this.ImportFromExcelButton_Click));
				return;
			case 15:
				this.c84d133f6e01cc85098ac63431589cbe3 = ccd4a1eb0fb8400369eeee136202f2af6.c9963fcf210a214a3206d6500f3b9397b(obj);
				c17218bee49a9a0f4ecfe597dd92968b3.c30767ddca1f9c207888833aea5b5fc61(this.c84d133f6e01cc85098ac63431589cbe3, new RoutedEventHandler(this.hideOfflineAccounts_Checked));
				cf445de9ec8bcec60337c69a8b9dd82f8.c30767ddca1f9c207888833aea5b5fc61(this.c84d133f6e01cc85098ac63431589cbe3, new RoutedEventHandler(this.hideOfflineAccounts_Checked));
				return;
			case 16:
				this.cbbc8bbcc1bf558ff8a0e06abd62f13d7 = ccd4a1eb0fb8400369eeee136202f2af6.c9963fcf210a214a3206d6500f3b9397b(obj);
				c17218bee49a9a0f4ecfe597dd92968b3.c30767ddca1f9c207888833aea5b5fc61(this.cbbc8bbcc1bf558ff8a0e06abd62f13d7, new RoutedEventHandler(this.hideUnusedServers_Checked));
				cf445de9ec8bcec60337c69a8b9dd82f8.c30767ddca1f9c207888833aea5b5fc61(this.cbbc8bbcc1bf558ff8a0e06abd62f13d7, new RoutedEventHandler(this.hideUnusedServers_Checked));
				return;
			case 17:
				this.c88aaa8af9bfe41a2300eab3d3ccb64f9 = ccd4a1eb0fb8400369eeee136202f2af6.c9963fcf210a214a3206d6500f3b9397b(obj);
				c17218bee49a9a0f4ecfe597dd92968b3.c30767ddca1f9c207888833aea5b5fc61(this.c88aaa8af9bfe41a2300eab3d3ccb64f9, new RoutedEventHandler(this.hideAllServers_Checked));
				cf445de9ec8bcec60337c69a8b9dd82f8.c30767ddca1f9c207888833aea5b5fc61(this.c88aaa8af9bfe41a2300eab3d3ccb64f9, new RoutedEventHandler(this.hideAllServers_Checked));
				return;
			case 18:
				this.cd0054e6502658391b6115d5c0bbcdea7 = cd25d3249a21fa4d0809e0465b99f4c67.c9963fcf210a214a3206d6500f3b9397b(obj);
				cbbe69a633a64f282083839bb52c8ad71.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, new MouseButtonEventHandler(this.accList_MouseRightButtonDown));
				c11bfd433702667049c3dddc9caa02ad6.c30767ddca1f9c207888833aea5b5fc61(this.cd0054e6502658391b6115d5c0bbcdea7, new RoutedPropertyChangedEventHandler<object>(this.accList_SelectedItemChanged));
				return;
			case 19:
				this.c137007dcdad6a7942fc1d5e11b9a4faa = c38ef33f5739a10bdc10bf86d4c872597.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 20:
				this.c79bca0a82227f5dd8dedfed145386680 = c38ef33f5739a10bdc10bf86d4c872597.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 21:
				this.c24b1965c9896834d4187c19ba7093972 = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 22:
				this.c9870c914e51fdff3e46125bc50d1f172 = c52bb1d35671e062f81dc359e76beb7b1.c9963fcf210a214a3206d6500f3b9397b(obj);
				c2554222853fb9673618d9527642f233a.c30767ddca1f9c207888833aea5b5fc61(this.c9870c914e51fdff3e46125bc50d1f172, new SelectionChangedEventHandler(this.clientLangSelectionChanged));
				return;
			case 23:
				this.c2e534450563d458d87ca6690b5def73d = c8ede41f0cf01663d5e5901623bd932b2.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 24:
				this.c14f96eb07e8321230b6d0e2532529e74 = c8ede41f0cf01663d5e5901623bd932b2.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 25:
				this.c7cae5f018601bb02de034644ccdc4dac = c8ede41f0cf01663d5e5901623bd932b2.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 26:
				this.c0e369422f408b2e020172466b4f8736c = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 27:
				this.cbe1ddf0fde4b9ba842959f4aa49bcf1c = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 28:
				this.c79329bbe9e1e2df0c7f633c7781cd41f = c52bb1d35671e062f81dc359e76beb7b1.c9963fcf210a214a3206d6500f3b9397b(obj);
				c2554222853fb9673618d9527642f233a.c30767ddca1f9c207888833aea5b5fc61(this.c79329bbe9e1e2df0c7f633c7781cd41f, new SelectionChangedEventHandler(this.gameWorld_SelectionChanged));
				return;
			case 29:
				this.c55c27af638ad45a0b38f2eaa2329a4c4 = c52bb1d35671e062f81dc359e76beb7b1.c9963fcf210a214a3206d6500f3b9397b(obj);
				c2554222853fb9673618d9527642f233a.c30767ddca1f9c207888833aea5b5fc61(this.c55c27af638ad45a0b38f2eaa2329a4c4, new SelectionChangedEventHandler(this.server_SelectionChanged));
				return;
			case 30:
				this.ccc0636f4a644fc4f9f06441bbe0c2846 = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 31:
				this.ce5ce055c72ecedf2962ba7fd9b5e7f5f = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 32:
				this.cc22bb4f2cff81a8f70e301227c30d3c4 = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 33:
				this.c154e386a06a48e617374cb3084b15d16 = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 34:
				this.c82ec624b8aadfbc9191641f0732a0585 = c52bb1d35671e062f81dc359e76beb7b1.c9963fcf210a214a3206d6500f3b9397b(obj);
				c2554222853fb9673618d9527642f233a.c30767ddca1f9c207888833aea5b5fc61(this.c82ec624b8aadfbc9191641f0732a0585, new SelectionChangedEventHandler(this.CharacterNumber_SelectionChanged));
				return;
			case 35:
				this.c9f561fbdac0b087661c3d93674314c66 = c5d285f41eba418cee80657070c7cbdf3.c9963fcf210a214a3206d6500f3b9397b(obj);
				c5eee560f258f53b31ce92308ebf8981a.c30767ddca1f9c207888833aea5b5fc61(this.c9f561fbdac0b087661c3d93674314c66, new TextChangedEventHandler(this.description_TextChanged));
				return;
			case 36:
				this.cb5466a044809fda944eb67b4c5d2c8f6 = c5d285f41eba418cee80657070c7cbdf3.c9963fcf210a214a3206d6500f3b9397b(obj);
				c5eee560f258f53b31ce92308ebf8981a.c30767ddca1f9c207888833aea5b5fc61(this.cb5466a044809fda944eb67b4c5d2c8f6, new TextChangedEventHandler(this.login_TextChanged));
				return;
			case 37:
				this.caee1e47a08a4ecec009fb2516f979104 = c5d285f41eba418cee80657070c7cbdf3.c9963fcf210a214a3206d6500f3b9397b(obj);
				c5eee560f258f53b31ce92308ebf8981a.c30767ddca1f9c207888833aea5b5fc61(this.caee1e47a08a4ecec009fb2516f979104, new TextChangedEventHandler(this.password_TextChanged));
				return;
			case 38:
				this.cd9d6c8eccb641592989df004f1e1c45f = c00d6bda88bbf8a154cdbabf38f2d7459.c9963fcf210a214a3206d6500f3b9397b(obj);
				c17218bee49a9a0f4ecfe597dd92968b3.c30767ddca1f9c207888833aea5b5fc61(this.cd9d6c8eccb641592989df004f1e1c45f, new RoutedEventHandler(this.UseSocks5_Checked));
				cf445de9ec8bcec60337c69a8b9dd82f8.c30767ddca1f9c207888833aea5b5fc61(this.cd9d6c8eccb641592989df004f1e1c45f, new RoutedEventHandler(this.UseSocks5_Checked));
				return;
			case 39:
				this.c0b6b42203c605a20b7c59af22954e91b = c35f480f9ac46b3423c93e197f5327315.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 40:
				this.c3f8ccec3c9716cc1310498718b64ea5e = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 41:
				this.c58344346cb86ff408ae0809ed6c973c3 = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 42:
				this.c12a7ad156cb9ad1cf39a52d76e06acb5 = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 43:
				this.c647d1308c87f5348cfe144e6821c97b2 = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 44:
				this.cefce72c9f3171228780df28ff61afccb = c35f480f9ac46b3423c93e197f5327315.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 45:
				this.c386b1b83ce21956322c985b3cb290769 = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 46:
				this.cc79f597a2913f924f2fe28dda0a22997 = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 47:
				this.c0a14c009d8a27ed957e23cfcb83bda29 = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 48:
				this.c94d2964e7b52ca96b96f6963a0b4debe = c3075cc50898eb3e5f7223d6a3a6800a6.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 49:
				this.cfb089fcc005d120966aebcd807c953eb = c5d285f41eba418cee80657070c7cbdf3.c9963fcf210a214a3206d6500f3b9397b(obj);
				c5eee560f258f53b31ce92308ebf8981a.c30767ddca1f9c207888833aea5b5fc61(this.cfb089fcc005d120966aebcd807c953eb, new TextChangedEventHandler(this.proxyIp_TextChanged));
				return;
			case 50:
				this.c43acd5b8aee8aac3eb34d311d73db4b9 = c5d285f41eba418cee80657070c7cbdf3.c9963fcf210a214a3206d6500f3b9397b(obj);
				c5eee560f258f53b31ce92308ebf8981a.c30767ddca1f9c207888833aea5b5fc61(this.c43acd5b8aee8aac3eb34d311d73db4b9, new TextChangedEventHandler(this.proxyPort_TextChanged));
				return;
			case 51:
				this.c19b1d008780db8f45326d62e4ae97cf1 = c5d285f41eba418cee80657070c7cbdf3.c9963fcf210a214a3206d6500f3b9397b(obj);
				c5eee560f258f53b31ce92308ebf8981a.c30767ddca1f9c207888833aea5b5fc61(this.c19b1d008780db8f45326d62e4ae97cf1, new TextChangedEventHandler(this.proxyLogin_TextChanged));
				return;
			case 52:
				this.c5448fced558b14e475d62f73ac05a864 = c5d285f41eba418cee80657070c7cbdf3.c9963fcf210a214a3206d6500f3b9397b(obj);
				c5eee560f258f53b31ce92308ebf8981a.c30767ddca1f9c207888833aea5b5fc61(this.c5448fced558b14e475d62f73ac05a864, new TextChangedEventHandler(this.proxyPassword_TextChanged));
				return;
			case 53:
				this.c5307093aef47df1751709d07538b52be = c00d6bda88bbf8a154cdbabf38f2d7459.c9963fcf210a214a3206d6500f3b9397b(obj);
				c17218bee49a9a0f4ecfe597dd92968b3.c30767ddca1f9c207888833aea5b5fc61(this.c5307093aef47df1751709d07538b52be, new RoutedEventHandler(this.AutoEnterGameWorld_Checked));
				cf445de9ec8bcec60337c69a8b9dd82f8.c30767ddca1f9c207888833aea5b5fc61(this.c5307093aef47df1751709d07538b52be, new RoutedEventHandler(this.AutoEnterGameWorld_Checked));
				return;
			case 54:
				this.c4953d61ea34c200d1a6de0f69c4a68a0 = c00d6bda88bbf8a154cdbabf38f2d7459.c9963fcf210a214a3206d6500f3b9397b(obj);
				c17218bee49a9a0f4ecfe597dd92968b3.c30767ddca1f9c207888833aea5b5fc61(this.c4953d61ea34c200d1a6de0f69c4a68a0, new RoutedEventHandler(this.AutoLaunchAccount_Checked));
				cf445de9ec8bcec60337c69a8b9dd82f8.c30767ddca1f9c207888833aea5b5fc61(this.c4953d61ea34c200d1a6de0f69c4a68a0, new RoutedEventHandler(this.AutoLaunchAccount_Checked));
				return;
			case 55:
				this.c32d431e171445fedfa242784a5820a56 = c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj);
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(this.c32d431e171445fedfa242784a5820a56, new RoutedEventHandler(this.NewToolStripButtonScheduler_Click));
				return;
			case 56:
				this.cccf7b701d7e8c96a5b5661ceffff1174 = c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj);
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(this.cccf7b701d7e8c96a5b5661ceffff1174, new RoutedEventHandler(this.DeleteToolStripButtonScheduler_Click));
				return;
			case 57:
				this.c8df21b00eff0ed569413a87a911e5013 = c00d6bda88bbf8a154cdbabf38f2d7459.c9963fcf210a214a3206d6500f3b9397b(obj);
				c17218bee49a9a0f4ecfe597dd92968b3.c30767ddca1f9c207888833aea5b5fc61(this.c8df21b00eff0ed569413a87a911e5013, new RoutedEventHandler(this.EnableSchedulerForAccount_Checked));
				cf445de9ec8bcec60337c69a8b9dd82f8.c30767ddca1f9c207888833aea5b5fc61(this.c8df21b00eff0ed569413a87a911e5013, new RoutedEventHandler(this.EnableSchedulerForAccount_Checked));
				return;
			case 58:
				this.c0b0afb159eaf61457df227310912e74e = c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj);
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(this.c0b0afb159eaf61457df227310912e74e, new RoutedEventHandler(this.ExportToCSVButton_Click));
				return;
			case 59:
				this.c661edb793c0ae9dd33ed1849ba92660b = c1e383189f23db47f5178917ba439b597.c9963fcf210a214a3206d6500f3b9397b(obj);
				c15fdf6dda051353f5e63c70dd32cde39.c30767ddca1f9c207888833aea5b5fc61(this.c661edb793c0ae9dd33ed1849ba92660b, new RoutedEventHandler(this.ImportFromCSVButton_Click));
				return;
			case 60:
				this.c2514f42a43aeead3c8908dc09d87fe68 = c637266d5d30131f3d04d2d9d6033dde8.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 61:
				this.c1045ad57787827135176c8e7b362fe86 = c52bb1d35671e062f81dc359e76beb7b1.c9963fcf210a214a3206d6500f3b9397b(obj);
				c2554222853fb9673618d9527642f233a.c30767ddca1f9c207888833aea5b5fc61(this.c1045ad57787827135176c8e7b362fe86, new SelectionChangedEventHandler(this.DayOfTheWeek_SelectionChanged));
				return;
			case 62:
				this.c8d495e9cc44c58f78c66024676ad9a57 = c5d285f41eba418cee80657070c7cbdf3.c9963fcf210a214a3206d6500f3b9397b(obj);
				c5eee560f258f53b31ce92308ebf8981a.c30767ddca1f9c207888833aea5b5fc61(this.c8d495e9cc44c58f78c66024676ad9a57, new TextChangedEventHandler(this.TimeFrom_TextChanged));
				return;
			case 63:
				this.c137952fe128ebb66ae21d036d05ec47c = c5d285f41eba418cee80657070c7cbdf3.c9963fcf210a214a3206d6500f3b9397b(obj);
				c5eee560f258f53b31ce92308ebf8981a.c30767ddca1f9c207888833aea5b5fc61(this.c137952fe128ebb66ae21d036d05ec47c, new TextChangedEventHandler(this.TimeTo_TextChanged));
				return;
			case 64:
				this.cfc72e1593fda015b04d1c33a1c5ae79d = c637266d5d30131f3d04d2d9d6033dde8.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 65:
				this.c155f664c997c9a5d6c158781375a2796 = c3268d52032f03bf24ef1948f66ae87c1.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 66:
				this.c86691c3d7259507eaad34cf7705ae6fd = c3268d52032f03bf24ef1948f66ae87c1.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			case 67:
				this.c13885786862bdc36510c4781ec731c97 = c3268d52032f03bf24ef1948f66ae87c1.c9963fcf210a214a3206d6500f3b9397b(obj);
				return;
			default:
				this.caa437f4d29d724a8a6620cffc7c41e4b = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21420) != 0);
				return;
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00065ADC File Offset: 0x00063CDC
		[CompilerGenerated]
		private static int c714501f6a77d2e2487da34a8d4c4d5c6(AccTreeViewInfo accTreeViewInfo)
		{
			return -accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00065AF8 File Offset: 0x00063CF8
		[CompilerGenerated]
		private static int c37e678a328db150c3510d930065b8772(AccTreeViewInfo accTreeViewInfo)
		{
			return -accTreeViewInfo.ce1ed6a6cb7304463ffd824d14b62f430.cfe2402a851c8636a5550251320efc6ac;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00065B14 File Offset: 0x00063D14
		[CompilerGenerated]
		private static bool c0630c9865e5d97f33fbbdde944073ef2(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21424) != 0;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00065B2C File Offset: 0x00063D2C
		[CompilerGenerated]
		private static bool ccaf16cc71c0f9e14d0b53c489a6b523d(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21428) != 0;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00065B44 File Offset: 0x00063D44
		[CompilerGenerated]
		private static bool ce40324fec72ba8769cbca6c1fa80eb54(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21432) != 0;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00065B5C File Offset: 0x00063D5C
		[CompilerGenerated]
		private static bool c96c76dae5667f7f46e4ce73776016eac(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21436) != 0;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00065B74 File Offset: 0x00063D74
		[CompilerGenerated]
		private static bool c384b6878438c08d54d15066b713740bd(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21440) != 0;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00065B8C File Offset: 0x00063D8C
		[CompilerGenerated]
		private static bool cd496a8d820d923d6c95458892c88d4af(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21444) != 0;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00065BA4 File Offset: 0x00063DA4
		[CompilerGenerated]
		private static bool c89cd6ca4c368a3e345b3de9f4f88c765(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21448) != 0;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00065BBC File Offset: 0x00063DBC
		[CompilerGenerated]
		private static bool cb6d87c96286ec427ae0f02f93e3d162e(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21452) != 0;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00065BD4 File Offset: 0x00063DD4
		[CompilerGenerated]
		private static bool c27b46e49e9cb1970039e43945d09cba0(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21456) != 0;
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00065BEC File Offset: 0x00063DEC
		[CompilerGenerated]
		private static bool cceec2213c64b82e4fea5675c51c5e9ce(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21460) != 0;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00065C04 File Offset: 0x00063E04
		[CompilerGenerated]
		private static bool c473bf4dbf6332266ad2f5716b83038e4(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21464) != 0;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00065C1C File Offset: 0x00063E1C
		[CompilerGenerated]
		private static bool c550e7728c28be11fb16fabeb19d9944f(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21468) != 0;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00065C34 File Offset: 0x00063E34
		[CompilerGenerated]
		private static bool cf9e00ae14a414ce3aab5c684e8417f41(object obj, X509Certificate x509Certificate, X509Chain x509Chain, SslPolicyErrors sslPolicyErrors)
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(21472) != 0;
		}

		// Token: 0x040005BD RID: 1469
		private c4abaf38aa559c219b0d9c3fcbe84127e cda9121000da1204e1c6c6b5074e82397;

		// Token: 0x040005BE RID: 1470
		public BitmapImage ce89a1360461e96761b4795a70dac68e0;

		// Token: 0x040005BF RID: 1471
		public BitmapImage c07a8d858e311edb907a0f502c43ccf29;

		// Token: 0x040005C0 RID: 1472
		public BitmapImage cd3c715e925438a82244546a84bd24ade;

		// Token: 0x040005C1 RID: 1473
		public BitmapImage cfb755cb93a73f30822ce601a125376d8;

		// Token: 0x040005C2 RID: 1474
		public BitmapImage c191cc919d4f42dd5a800d55c995e0acd;

		// Token: 0x040005C3 RID: 1475
		public BitmapImage c9a1aad0eb9412e7785834b30ef2fef12;

		// Token: 0x040005C4 RID: 1476
		public BitmapImage cb9bcf976186c79f4c709eebcd63eda46;

		// Token: 0x040005C5 RID: 1477
		public BitmapImage c8de530f3e6382d3b2f91780631d61919;

		// Token: 0x040005C6 RID: 1478
		private Dictionary<string, DateTime> cf0c4d7a7923fac23e87115a1e3b966fc = new Dictionary<string, DateTime>();

		// Token: 0x040005C7 RID: 1479
		private Dictionary<string, DateTime> c8bcf018135c2879adb54db7c997572f1 = new Dictionary<string, DateTime>();

		// Token: 0x040005C8 RID: 1480
		private Dictionary<string, c8bcd65ef9c4ef9760bfa9987e3b9d9f7> cf3f1975cf13c851b2e7343e0b5d97e7d;

		// Token: 0x040005C9 RID: 1481
		private ObservableCollection<SchedulerInfo> c2e1956eefc5b4edaa1fa8515bd955ae7;

		// Token: 0x040005CA RID: 1482
		private ObservableCollection<PluginInfoDataGrid> c854bacc98918774f7cd95449627b0cbf;

		// Token: 0x040005CB RID: 1483
		private ObservableCollection<AccTreeViewInfo> cd559d791bccc45933a81e7e47e42fd1b = new ObservableCollection<AccTreeViewInfo>();

		// Token: 0x040005CC RID: 1484
		private System.Windows.Point c5cb9b3ac544907604be054c2a4b2f785;

		// Token: 0x040005CD RID: 1485
		public BitmapImage c0d8c68555854f07d401b833fcf35300e;

		// Token: 0x040005CE RID: 1486
		public BitmapImage cd2322d00bb2b1846e002c867c614232d;

		// Token: 0x040005CF RID: 1487
		public BitmapImage c3c897f76a0f75ab801de66894978eafa;

		// Token: 0x040005D0 RID: 1488
		public BitmapImage c1d19582cffe423a1124756d0fe13de8d;

		// Token: 0x040005D1 RID: 1489
		private ServerTreeViewInfo c08f8a3c6f01bd44442b9cbfc43c9459a;

		// Token: 0x040005D2 RID: 1490
		private AccTreeViewInfo ccfcabad6787ff6760a732cf8c31045ff;

		// Token: 0x040005D3 RID: 1491
		internal ca0c9ecd43ccad62ae7ac89ac45149827 ca363176affcc7719c87ca60ddb5f6f34;

		// Token: 0x040005D4 RID: 1492
		private System.Windows.Controls.ContextMenu cde612ef6cd46010d5aa48e8da32c8dd1;

		// Token: 0x040005D5 RID: 1493
		private ObservableCollection<WorldTreeViewInfo> c4fc5dab2c31ad3f0faa92b746c49837e = new ObservableCollection<WorldTreeViewInfo>();

		// Token: 0x040005D6 RID: 1494
		private ObservableCollection<ServerTreeViewInfo> c211a8cb0fd0860bc469ed8ef20980300 = new ObservableCollection<ServerTreeViewInfo>();

		// Token: 0x040005D7 RID: 1495
		private ObservableCollection<ServerTreeViewInfo> c2d1e187c9efce20e55655d518436259c = new ObservableCollection<ServerTreeViewInfo>();

		// Token: 0x040005D8 RID: 1496
		private ObservableCollection<ServerTreeViewInfo> cd9db19395aea8d58426dab9ecf93bb34 = new ObservableCollection<ServerTreeViewInfo>();

		// Token: 0x040005D9 RID: 1497
		private static Random random;

		// Token: 0x040005DA RID: 1498
		private int c940496334965a9294f8ecceea416c5df;

		// Token: 0x040005DB RID: 1499
		internal TextBlock ce934d236e27a0409842ab9ea408c5e28;

		// Token: 0x040005DC RID: 1500
		internal TextBlock c1597bd055f3af8220d98461ee8436c4b;

		// Token: 0x040005DD RID: 1501
		internal System.Windows.Controls.ToolBar cb6835b9ed55a6df7200b528c72321ded;

		// Token: 0x040005DE RID: 1502
		internal System.Windows.Controls.Button c47bd676f1de5d85d70d684d663cbddd7;

		// Token: 0x040005DF RID: 1503
		internal ToggleButton c84d133f6e01cc85098ac63431589cbe3;

		// Token: 0x040005E0 RID: 1504
		internal ToggleButton cbbc8bbcc1bf558ff8a0e06abd62f13d7;

		// Token: 0x040005E1 RID: 1505
		internal ToggleButton c88aaa8af9bfe41a2300eab3d3ccb64f9;

		// Token: 0x040005E2 RID: 1506
		internal System.Windows.Controls.TreeView cd0054e6502658391b6115d5c0bbcdea7;

		// Token: 0x040005E3 RID: 1507
		internal System.Windows.Controls.TabControl c137007dcdad6a7942fc1d5e11b9a4faa;

		// Token: 0x040005E4 RID: 1508
		internal System.Windows.Controls.TabControl c79bca0a82227f5dd8dedfed145386680;

		// Token: 0x040005E5 RID: 1509
		internal System.Windows.Controls.Label c24b1965c9896834d4187c19ba7093972;

		// Token: 0x040005E6 RID: 1510
		internal System.Windows.Controls.ComboBox c9870c914e51fdff3e46125bc50d1f172;

		// Token: 0x040005E7 RID: 1511
		internal ComboBoxItem c2e534450563d458d87ca6690b5def73d;

		// Token: 0x040005E8 RID: 1512
		internal ComboBoxItem c14f96eb07e8321230b6d0e2532529e74;

		// Token: 0x040005E9 RID: 1513
		internal ComboBoxItem c7cae5f018601bb02de034644ccdc4dac;

		// Token: 0x040005EA RID: 1514
		internal System.Windows.Controls.Label c0e369422f408b2e020172466b4f8736c;

		// Token: 0x040005EB RID: 1515
		internal System.Windows.Controls.Label cbe1ddf0fde4b9ba842959f4aa49bcf1c;

		// Token: 0x040005EC RID: 1516
		internal System.Windows.Controls.ComboBox c79329bbe9e1e2df0c7f633c7781cd41f;

		// Token: 0x040005ED RID: 1517
		internal System.Windows.Controls.ComboBox c55c27af638ad45a0b38f2eaa2329a4c4;

		// Token: 0x040005EE RID: 1518
		internal System.Windows.Controls.Label ccc0636f4a644fc4f9f06441bbe0c2846;

		// Token: 0x040005EF RID: 1519
		internal System.Windows.Controls.Label ce5ce055c72ecedf2962ba7fd9b5e7f5f;

		// Token: 0x040005F0 RID: 1520
		internal System.Windows.Controls.Label cc22bb4f2cff81a8f70e301227c30d3c4;

		// Token: 0x040005F1 RID: 1521
		internal System.Windows.Controls.Label c154e386a06a48e617374cb3084b15d16;

		// Token: 0x040005F2 RID: 1522
		internal System.Windows.Controls.ComboBox c82ec624b8aadfbc9191641f0732a0585;

		// Token: 0x040005F3 RID: 1523
		internal System.Windows.Controls.TextBox c9f561fbdac0b087661c3d93674314c66;

		// Token: 0x040005F4 RID: 1524
		internal System.Windows.Controls.TextBox cb5466a044809fda944eb67b4c5d2c8f6;

		// Token: 0x040005F5 RID: 1525
		internal System.Windows.Controls.TextBox caee1e47a08a4ecec009fb2516f979104;

		// Token: 0x040005F6 RID: 1526
		internal System.Windows.Controls.CheckBox cd9d6c8eccb641592989df004f1e1c45f;

		// Token: 0x040005F7 RID: 1527
		internal System.Windows.Controls.GroupBox c0b6b42203c605a20b7c59af22954e91b;

		// Token: 0x040005F8 RID: 1528
		internal System.Windows.Controls.Label c3f8ccec3c9716cc1310498718b64ea5e;

		// Token: 0x040005F9 RID: 1529
		internal System.Windows.Controls.Label c58344346cb86ff408ae0809ed6c973c3;

		// Token: 0x040005FA RID: 1530
		internal System.Windows.Controls.Label c12a7ad156cb9ad1cf39a52d76e06acb5;

		// Token: 0x040005FB RID: 1531
		internal System.Windows.Controls.Label c647d1308c87f5348cfe144e6821c97b2;

		// Token: 0x040005FC RID: 1532
		internal System.Windows.Controls.GroupBox cefce72c9f3171228780df28ff61afccb;

		// Token: 0x040005FD RID: 1533
		internal System.Windows.Controls.Label c386b1b83ce21956322c985b3cb290769;

		// Token: 0x040005FE RID: 1534
		internal System.Windows.Controls.Label cc79f597a2913f924f2fe28dda0a22997;

		// Token: 0x040005FF RID: 1535
		internal System.Windows.Controls.Label c0a14c009d8a27ed957e23cfcb83bda29;

		// Token: 0x04000600 RID: 1536
		internal System.Windows.Controls.Label c94d2964e7b52ca96b96f6963a0b4debe;

		// Token: 0x04000601 RID: 1537
		internal System.Windows.Controls.TextBox cfb089fcc005d120966aebcd807c953eb;

		// Token: 0x04000602 RID: 1538
		internal System.Windows.Controls.TextBox c43acd5b8aee8aac3eb34d311d73db4b9;

		// Token: 0x04000603 RID: 1539
		internal System.Windows.Controls.TextBox c19b1d008780db8f45326d62e4ae97cf1;

		// Token: 0x04000604 RID: 1540
		internal System.Windows.Controls.TextBox c5448fced558b14e475d62f73ac05a864;

		// Token: 0x04000605 RID: 1541
		internal System.Windows.Controls.CheckBox c5307093aef47df1751709d07538b52be;

		// Token: 0x04000606 RID: 1542
		internal System.Windows.Controls.CheckBox c4953d61ea34c200d1a6de0f69c4a68a0;

		// Token: 0x04000607 RID: 1543
		internal System.Windows.Controls.Button c32d431e171445fedfa242784a5820a56;

		// Token: 0x04000608 RID: 1544
		internal System.Windows.Controls.Button cccf7b701d7e8c96a5b5661ceffff1174;

		// Token: 0x04000609 RID: 1545
		internal System.Windows.Controls.CheckBox c8df21b00eff0ed569413a87a911e5013;

		// Token: 0x0400060A RID: 1546
		internal System.Windows.Controls.Button c0b0afb159eaf61457df227310912e74e;

		// Token: 0x0400060B RID: 1547
		internal System.Windows.Controls.Button c661edb793c0ae9dd33ed1849ba92660b;

		// Token: 0x0400060C RID: 1548
		internal System.Windows.Controls.DataGrid c2514f42a43aeead3c8908dc09d87fe68;

		// Token: 0x0400060D RID: 1549
		internal System.Windows.Controls.ComboBox c1045ad57787827135176c8e7b362fe86;

		// Token: 0x0400060E RID: 1550
		internal System.Windows.Controls.TextBox c8d495e9cc44c58f78c66024676ad9a57;

		// Token: 0x0400060F RID: 1551
		internal System.Windows.Controls.TextBox c137952fe128ebb66ae21d036d05ec47c;

		// Token: 0x04000610 RID: 1552
		internal System.Windows.Controls.DataGrid cfc72e1593fda015b04d1c33a1c5ae79d;

		// Token: 0x04000611 RID: 1553
		internal TextBlock c155f664c997c9a5d6c158781375a2796;

		// Token: 0x04000612 RID: 1554
		internal TextBlock c86691c3d7259507eaad34cf7705ae6fd;

		// Token: 0x04000613 RID: 1555
		internal TextBlock c13885786862bdc36510c4781ec731c97;

		// Token: 0x04000614 RID: 1556
		private bool caa437f4d29d724a8a6620cffc7c41e4b;

		// Token: 0x02000129 RID: 297
		private struct c8a52867e86c70d29f644cd95db0728a4
		{
			// Token: 0x04000624 RID: 1572
			public string c279d72299fc1a7f545ad43126ff18dbe;

			// Token: 0x04000625 RID: 1573
			public System.Drawing.Color cd4e00ad3d769e8634db871a069991a75;
		}

		// Token: 0x02000584 RID: 1412
		[CompilerGenerated]
		private sealed class c419c1226a9df336fca651c1f31ce5861
		{
			// Token: 0x06001F87 RID: 8071 RVA: 0x00144800 File Offset: 0x00142A00
			public void ce9f32637bede6bf4a48154720b3f2692()
			{
				try
				{
					MyTabItem myTabItem = cbc8a8d17f8261e8e9f9884f3837683f1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					c41bb22f7038021d01ea57b9e11f6d426.c30767ddca1f9c207888833aea5b5fc61(myTabItem, this.c7a0383e67c28fa211b6e3f641eebf67a.c5201a71819ca9f9594b135ac31948215);
					c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(myTabItem, this.c7a0383e67c28fa211b6e3f641eebf67a.c7a0383e67c28fa211b6e3f641eebf67a);
					c2edbda8e92502aa789de010d8e8c218b.c30767ddca1f9c207888833aea5b5fc61(myTabItem, new RoutedEventHandler(this.cb6ea3d298d68be569f5410cc290458d5.tab_onRemove));
					c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.cb6ea3d298d68be569f5410cc290458d5.c137007dcdad6a7942fc1d5e11b9a4faa), myTabItem);
					c29c9e2e3faaeaa8f38c43a85bf39d6d3.c30767ddca1f9c207888833aea5b5fc61(this.cb6ea3d298d68be569f5410cc290458d5.c137007dcdad6a7942fc1d5e11b9a4faa, myTabItem);
					this.c7a0383e67c28fa211b6e3f641eebf67a.c773f838d678cd0af3ed65ba3a8517ed6 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97952) != 0);
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
			}

			// Token: 0x0400150C RID: 5388
			public cbf4111912aed594f2b4372828dd95aa3 cb6ea3d298d68be569f5410cc290458d5;

			// Token: 0x0400150D RID: 5389
			public c8bcd65ef9c4ef9760bfa9987e3b9d9f7 c7a0383e67c28fa211b6e3f641eebf67a;
		}

		// Token: 0x02000585 RID: 1413
		[CompilerGenerated]
		private sealed class ca7d9f6c15dad312217b0b35d021f7352
		{
			// Token: 0x06001F89 RID: 8073 RVA: 0x001448C4 File Offset: 0x00142AC4
			public void c1bd5f84fed3cdb5a0214f6c03ec0f931()
			{
				try
				{
					System.Windows.Controls.RichTextBox richTextBox = c71233cb4566b530e70693471b152e196.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					c89b47485b65ed55dafb58d4d196876c9.c30767ddca1f9c207888833aea5b5fc61(richTextBox, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203024));
					c0f443f67914f754383d653bd9b4ec024.c30767ddca1f9c207888833aea5b5fc61(richTextBox, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97956));
					cedcd16e04671fc7c0cc49f23da209653.c30767ddca1f9c207888833aea5b5fc61(richTextBox, (ScrollBarVisibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97960));
					cf3a4b4ee713b125742d7d5d2efa6a34b.c30767ddca1f9c207888833aea5b5fc61(richTextBox, (ScrollBarVisibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97964));
					cba1e39290c1a615ea3a5fc4759ae77c4.c30767ddca1f9c207888833aea5b5fc61(richTextBox, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97968) != 0);
					cb2ea3bc21dab3f91128fb49942876e65.c30767ddca1f9c207888833aea5b5fc61(richTextBox, c138813feaf2ff92fc3fae32f6bff926a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4b28c4e284b41e53e95b4c00be66dc54.c0cf59c3e67a46fd4edb3040c5ab0bbfb((byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97972), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97976), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97980))));
					c82b3f801decf1773bef835cb746d68ea.c30767ddca1f9c207888833aea5b5fc61(richTextBox, (System.Windows.HorizontalAlignment)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97984));
					cc69e10fb605c7ab7f8d2c6aa4dccdbbd.c30767ddca1f9c207888833aea5b5fc61(richTextBox, (VerticalAlignment)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97988));
					c34a6e19ac0fe6338baabd047435fb057.c30767ddca1f9c207888833aea5b5fc61(richTextBox, c138813feaf2ff92fc3fae32f6bff926a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4b28c4e284b41e53e95b4c00be66dc54.c0cf59c3e67a46fd4edb3040c5ab0bbfb((byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97992), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97996), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98000))));
					c101fb4bc9d3c4485f5645b15504cc217.c30767ddca1f9c207888833aea5b5fc61(richTextBox, c138813feaf2ff92fc3fae32f6bff926a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4b28c4e284b41e53e95b4c00be66dc54.c0cf59c3e67a46fd4edb3040c5ab0bbfb((byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98004), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98008), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98012))));
					c19649dc402d3ced942e9582946c3e128.c30767ddca1f9c207888833aea5b5fc61(richTextBox, c138813feaf2ff92fc3fae32f6bff926a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4b28c4e284b41e53e95b4c00be66dc54.c0cf59c3e67a46fd4edb3040c5ab0bbfb((byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98016), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98020), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98024))));
					c26766cd0ee947cdb364020c4ce670120.c30767ddca1f9c207888833aea5b5fc61(richTextBox, cd2f7f36388909b20e9ee0b26a5023315.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(160627)));
					c75607ccd6667b415790d680d7353a18b.c30767ddca1f9c207888833aea5b5fc61(richTextBox, new Thickness(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(98028)));
					c5e191bce020ce63473286d9ec31efb1d.c30767ddca1f9c207888833aea5b5fc61(cfcdcac93cafe5fdbec02cf364efbf061.c30767ddca1f9c207888833aea5b5fc61(cea02c1fc40e9870976da23623832bf1b.c30767ddca1f9c207888833aea5b5fc61(richTextBox)));
					c5eee560f258f53b31ce92308ebf8981a.c30767ddca1f9c207888833aea5b5fc61(richTextBox, new TextChangedEventHandler(this.cb6ea3d298d68be569f5410cc290458d5.tb_TextChanged));
					MyTabItem myTabItem = cbc8a8d17f8261e8e9f9884f3837683f1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					c9a7a93831a77f8c53d0278683d6dec25.c30767ddca1f9c207888833aea5b5fc61(myTabItem, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98036) != 0);
					c2edbda8e92502aa789de010d8e8c218b.c30767ddca1f9c207888833aea5b5fc61(myTabItem, new RoutedEventHandler(this.cb6ea3d298d68be569f5410cc290458d5.tab_onRemove));
					c41bb22f7038021d01ea57b9e11f6d426.c30767ddca1f9c207888833aea5b5fc61(myTabItem, this.c48300d096770fcd924fa7ebade9fd6a3);
					c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(myTabItem, richTextBox);
					c7ff21f62d332dfdc0e80d390755f8381.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(this.cb6ea3d298d68be569f5410cc290458d5.c137007dcdad6a7942fc1d5e11b9a4faa), myTabItem);
					c29c9e2e3faaeaa8f38c43a85bf39d6d3.c30767ddca1f9c207888833aea5b5fc61(this.cb6ea3d298d68be569f5410cc290458d5.c137007dcdad6a7942fc1d5e11b9a4faa, myTabItem);
					c8bcd65ef9c4ef9760bfa9987e3b9d9f7 c8bcd65ef9c4ef9760bfa9987e3b9d9f = new c8bcd65ef9c4ef9760bfa9987e3b9d9f7();
					c8bcd65ef9c4ef9760bfa9987e3b9d9f.c7a0383e67c28fa211b6e3f641eebf67a = richTextBox;
					c8bcd65ef9c4ef9760bfa9987e3b9d9f.c773f838d678cd0af3ed65ba3a8517ed6 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98040) != 0);
					c8bcd65ef9c4ef9760bfa9987e3b9d9f.c5201a71819ca9f9594b135ac31948215 = this.c48300d096770fcd924fa7ebade9fd6a3;
					cec7214edd1ecff1cbe0c39417a38c320.c30767ddca1f9c207888833aea5b5fc61(this.cb6ea3d298d68be569f5410cc290458d5.cf3f1975cf13c851b2e7343e0b5d97e7d, this.c48300d096770fcd924fa7ebade9fd6a3, c8bcd65ef9c4ef9760bfa9987e3b9d9f);
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
			}

			// Token: 0x0400150E RID: 5390
			public cbf4111912aed594f2b4372828dd95aa3 cb6ea3d298d68be569f5410cc290458d5;

			// Token: 0x0400150F RID: 5391
			public string c48300d096770fcd924fa7ebade9fd6a3;
		}

		// Token: 0x02000586 RID: 1414
		[CompilerGenerated]
		private sealed class c17239c9cccf3493ba3ee09147f6ecc4a
		{
			// Token: 0x06001F8B RID: 8075 RVA: 0x00144B5C File Offset: 0x00142D5C
			public void c28ccbcf9559ddfb0aa343124b0e6ef45()
			{
				try
				{
					cbba39365cc360185f014cd421fd7a123.c30767ddca1f9c207888833aea5b5fc61(this.c3b3af64991b29c36fd4ca79eb06ec59b.c7a0383e67c28fa211b6e3f641eebf67a, ce737e47ff133e19943a2c3ff95de91dc.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
			}

			// Token: 0x04001510 RID: 5392
			public c8bcd65ef9c4ef9760bfa9987e3b9d9f7 c3b3af64991b29c36fd4ca79eb06ec59b;
		}

		// Token: 0x02000587 RID: 1415
		[CompilerGenerated]
		private sealed class cdbdbbb0fa695f1526f03e8723de7f431
		{
			// Token: 0x04001511 RID: 5393
			public System.Drawing.Color cd4e00ad3d769e8634db871a069991a75;
		}

		// Token: 0x02000588 RID: 1416
		[CompilerGenerated]
		private sealed class c42b74606b23c194db966233814bf1d35
		{
			// Token: 0x06001F8E RID: 8078 RVA: 0x00144BCC File Offset: 0x00142DCC
			public void c7c2f5c3ebb34b694e3fac50d650c9b71()
			{
				try
				{
					c34a6e19ac0fe6338baabd047435fb057.c30767ddca1f9c207888833aea5b5fc61(this.c3b3af64991b29c36fd4ca79eb06ec59b.c7a0383e67c28fa211b6e3f641eebf67a, c138813feaf2ff92fc3fae32f6bff926a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c730dcb95bc65b1e261dc732536b565f9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc36ec8841474c7f4d5e0264f7a0466c0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c75c88b595486185bda84f394888b039a.cd4e00ad3d769e8634db871a069991a75), c25aeab9571d22cd49646c565442c6a27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c75c88b595486185bda84f394888b039a.cd4e00ad3d769e8634db871a069991a75), caad2c1d302e3ce2d7275439e77f61494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c75c88b595486185bda84f394888b039a.cd4e00ad3d769e8634db871a069991a75), ce5de72fdd04e5cd615611d8889b41953.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c75c88b595486185bda84f394888b039a.cd4e00ad3d769e8634db871a069991a75))));
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
			}

			// Token: 0x04001512 RID: 5394
			public cbf4111912aed594f2b4372828dd95aa3.cdbdbbb0fa695f1526f03e8723de7f431 c75c88b595486185bda84f394888b039a;

			// Token: 0x04001513 RID: 5395
			public c8bcd65ef9c4ef9760bfa9987e3b9d9f7 c3b3af64991b29c36fd4ca79eb06ec59b;
		}

		// Token: 0x02000589 RID: 1417
		[CompilerGenerated]
		private sealed class ca6bbc4dff6abf9961b798d2c33f0f5dc
		{
			// Token: 0x04001514 RID: 5396
			public string c195a54fbdf960ff8ef1ef331acb79a1a;

			// Token: 0x04001515 RID: 5397
			public System.Drawing.Color cd4e00ad3d769e8634db871a069991a75;

			// Token: 0x04001516 RID: 5398
			public bool c4bad6262985be3f53a16074916f6fcec;
		}

		// Token: 0x0200058A RID: 1418
		[CompilerGenerated]
		private sealed class cc70c0687bdf847e6bb523ea92e8d5934
		{
			// Token: 0x06001F91 RID: 8081 RVA: 0x00144C8C File Offset: 0x00142E8C
			public void c9db941f8da6c1beb6f50c283f537bcc6()
			{
				try
				{
					TextRange textRange = cf6769ac0a4a27e24cb7148585829cb45.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c2ede143ff23cca0c375301ccdd6b9f01.c30767ddca1f9c207888833aea5b5fc61(cea02c1fc40e9870976da23623832bf1b.c30767ddca1f9c207888833aea5b5fc61(this.c3b3af64991b29c36fd4ca79eb06ec59b.c7a0383e67c28fa211b6e3f641eebf67a)), c2ede143ff23cca0c375301ccdd6b9f01.c30767ddca1f9c207888833aea5b5fc61(cea02c1fc40e9870976da23623832bf1b.c30767ddca1f9c207888833aea5b5fc61(this.c3b3af64991b29c36fd4ca79eb06ec59b.c7a0383e67c28fa211b6e3f641eebf67a)));
					if (this.c2c71f2d7a522415a7cd1c9439cda17b1.c4bad6262985be3f53a16074916f6fcec)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_59_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.cc70c0687bdf847e6bb523ea92e8d5934.c9db941f8da6c1beb6f50c283f537bcc6()).MethodHandle;
						}
						cbf4111912aed594f2b4372828dd95aa3.ca6bbc4dff6abf9961b798d2c33f0f5dc expr_60 = this.c2c71f2d7a522415a7cd1c9439cda17b1;
						expr_60.c195a54fbdf960ff8ef1ef331acb79a1a = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_60.c195a54fbdf960ff8ef1ef331acb79a1a, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(156861));
					}
					c528dcef79b14dbeeb5b5157c79b03c01.c30767ddca1f9c207888833aea5b5fc61(textRange, this.c2c71f2d7a522415a7cd1c9439cda17b1.c195a54fbdf960ff8ef1ef331acb79a1a);
					SolidColorBrush solidColorBrush = c138813feaf2ff92fc3fae32f6bff926a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c730dcb95bc65b1e261dc732536b565f9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc36ec8841474c7f4d5e0264f7a0466c0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c2c71f2d7a522415a7cd1c9439cda17b1.cd4e00ad3d769e8634db871a069991a75), c25aeab9571d22cd49646c565442c6a27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c2c71f2d7a522415a7cd1c9439cda17b1.cd4e00ad3d769e8634db871a069991a75), caad2c1d302e3ce2d7275439e77f61494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c2c71f2d7a522415a7cd1c9439cda17b1.cd4e00ad3d769e8634db871a069991a75), ce5de72fdd04e5cd615611d8889b41953.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c2c71f2d7a522415a7cd1c9439cda17b1.cd4e00ad3d769e8634db871a069991a75)));
					c6a592641d47fbbb590721e5924eb903c.c30767ddca1f9c207888833aea5b5fc61(textRange, TextElement.ForegroundProperty, solidColorBrush);
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
			}

			// Token: 0x04001517 RID: 5399
			public cbf4111912aed594f2b4372828dd95aa3.ca6bbc4dff6abf9961b798d2c33f0f5dc c2c71f2d7a522415a7cd1c9439cda17b1;

			// Token: 0x04001518 RID: 5400
			public c8bcd65ef9c4ef9760bfa9987e3b9d9f7 c3b3af64991b29c36fd4ca79eb06ec59b;
		}

		// Token: 0x0200058B RID: 1419
		[CompilerGenerated]
		private sealed class c4b5a63e5fdca11ac13bd0e78dd642df7
		{
			// Token: 0x06001F93 RID: 8083 RVA: 0x00144DC4 File Offset: 0x00142FC4
			public void c512cfa55766576c33e87353867872bf6()
			{
				this.cb6ea3d298d68be569f5410cc290458d5.c27dd6fc0a36cf582997f24bf3bc5ff2e(this.c97bb0419a7a851c991e9e986b8e0f5c1);
			}

			// Token: 0x04001519 RID: 5401
			public AccTreeViewInfo c97bb0419a7a851c991e9e986b8e0f5c1;

			// Token: 0x0400151A RID: 5402
			public cbf4111912aed594f2b4372828dd95aa3 cb6ea3d298d68be569f5410cc290458d5;
		}

		// Token: 0x0200058C RID: 1420
		[CompilerGenerated]
		private sealed class cd817f0078f4e100ef0941cb6d95929ac
		{
			// Token: 0x06001F95 RID: 8085 RVA: 0x00144DF8 File Offset: 0x00142FF8
			public bool cc92c189e94fbf60d0cc30dbe1fd5284a(ServerTreeViewInfo serverTreeViewInfo)
			{
				return (int)serverTreeViewInfo.cb5905b594e11dea2f73932df05981674 == this.c26ea3c7ce5f285bcc575c946b4c282bf;
			}

			// Token: 0x06001F96 RID: 8086 RVA: 0x00144E14 File Offset: 0x00143014
			public bool c4fc4af6c56d1ae9de97168baaaad7ac9(ServerTreeViewInfo serverTreeViewInfo)
			{
				return (int)serverTreeViewInfo.cb5905b594e11dea2f73932df05981674 == this.c26ea3c7ce5f285bcc575c946b4c282bf;
			}

			// Token: 0x06001F97 RID: 8087 RVA: 0x00144E30 File Offset: 0x00143030
			public bool c71dc569cf8b07858ff3813bd93caa417(ServerTreeViewInfo serverTreeViewInfo)
			{
				return (int)serverTreeViewInfo.cb5905b594e11dea2f73932df05981674 == this.c26ea3c7ce5f285bcc575c946b4c282bf;
			}

			// Token: 0x06001F98 RID: 8088 RVA: 0x00144E4C File Offset: 0x0014304C
			public bool cbed718e6a8ef597fb0e1c66908d25c3c(ServerTreeViewInfo serverTreeViewInfo)
			{
				return (int)serverTreeViewInfo.cb5905b594e11dea2f73932df05981674 == this.c26ea3c7ce5f285bcc575c946b4c282bf;
			}

			// Token: 0x06001F99 RID: 8089 RVA: 0x00144E68 File Offset: 0x00143068
			public bool c027c35b576e8c88a2cb4a8e5315e56d6(ServerTreeViewInfo serverTreeViewInfo)
			{
				return (int)serverTreeViewInfo.cb5905b594e11dea2f73932df05981674 == this.c26ea3c7ce5f285bcc575c946b4c282bf;
			}

			// Token: 0x06001F9A RID: 8090 RVA: 0x00144E84 File Offset: 0x00143084
			public bool c3586ef64fef39cacabfa6990543c5c4a(ServerTreeViewInfo serverTreeViewInfo)
			{
				return (int)serverTreeViewInfo.cb5905b594e11dea2f73932df05981674 == this.c26ea3c7ce5f285bcc575c946b4c282bf;
			}

			// Token: 0x0400151B RID: 5403
			public int c26ea3c7ce5f285bcc575c946b4c282bf;
		}

		// Token: 0x0200058D RID: 1421
		[CompilerGenerated]
		private sealed class c5d9d07cc750d812b82f036c97aa9630c
		{
			// Token: 0x06001F9C RID: 8092 RVA: 0x00144EB4 File Offset: 0x001430B4
			public HitTestResultBehavior c4f8275e2c0709d49ce2c844671851ab7(HitTestResult hitTestResult)
			{
				System.Windows.Controls.DataGridCell dataGridCell = this.cb6ea3d298d68be569f5410cc290458d5.c7cb14ecf42ff93ff27b34e69b5e250ec<System.Windows.Controls.DataGridCell>(c4d1714519cc897c1242f11bc9f18f33d.c30767ddca1f9c207888833aea5b5fc61(hitTestResult));
				if (dataGridCell != null)
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_2B_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c5d9d07cc750d812b82f036c97aa9630c.c4f8275e2c0709d49ce2c844671851ab7(HitTestResult)).MethodHandle;
					}
					this.c47dc92cd06388f50f3ac3727d2ccc67d = dataGridCell;
					return (HitTestResultBehavior)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98044);
				}
				return (HitTestResultBehavior)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98048);
			}

			// Token: 0x0400151C RID: 5404
			public System.Windows.Controls.DataGridCell c47dc92cd06388f50f3ac3727d2ccc67d;

			// Token: 0x0400151D RID: 5405
			public cbf4111912aed594f2b4372828dd95aa3 cb6ea3d298d68be569f5410cc290458d5;
		}

		// Token: 0x0200058E RID: 1422
		[CompilerGenerated]
		private sealed class cfd399d684d99ddae7d7f6b3323f10340
		{
			// Token: 0x06001F9E RID: 8094 RVA: 0x00144F20 File Offset: 0x00143120
			public HitTestResultBehavior cd84862e5eb9e327e5e99c17b42bb4ea3(HitTestResult hitTestResult)
			{
				System.Windows.Controls.DataGridCell dataGridCell = this.cb6ea3d298d68be569f5410cc290458d5.c7cb14ecf42ff93ff27b34e69b5e250ec<System.Windows.Controls.DataGridCell>(c4d1714519cc897c1242f11bc9f18f33d.c30767ddca1f9c207888833aea5b5fc61(hitTestResult));
				if (dataGridCell != null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_2B_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.cfd399d684d99ddae7d7f6b3323f10340.cd84862e5eb9e327e5e99c17b42bb4ea3(HitTestResult)).MethodHandle;
					}
					this.c47dc92cd06388f50f3ac3727d2ccc67d = dataGridCell;
					return (HitTestResultBehavior)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98052);
				}
				return (HitTestResultBehavior)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98056);
			}

			// Token: 0x0400151E RID: 5406
			public System.Windows.Controls.DataGridCell c47dc92cd06388f50f3ac3727d2ccc67d;

			// Token: 0x0400151F RID: 5407
			public cbf4111912aed594f2b4372828dd95aa3 cb6ea3d298d68be569f5410cc290458d5;
		}

		// Token: 0x0200058F RID: 1423
		[CompilerGenerated]
		private sealed class c1b335898911b58d721104396217b5d94
		{
			// Token: 0x06001FA0 RID: 8096 RVA: 0x00144F8C File Offset: 0x0014318C
			public void c3df32bcf069e3635c279c2e6d25a6540()
			{
				this.c358790ce1997e11a2edc326a8a5965f7 = cfd37b0b68a1b2b9f71b23c50e45f8528.cea69e7c4d1a729bd5783221de1566e79(c02f19c35401b8698fadb0df9d715ffe2.c30767ddca1f9c207888833aea5b5fc61(this.cb6ea3d298d68be569f5410cc290458d5.cd0054e6502658391b6115d5c0bbcdea7));
			}

			// Token: 0x04001520 RID: 5408
			public AccTreeViewInfo c358790ce1997e11a2edc326a8a5965f7;

			// Token: 0x04001521 RID: 5409
			public cbf4111912aed594f2b4372828dd95aa3 cb6ea3d298d68be569f5410cc290458d5;
		}

		// Token: 0x02000590 RID: 1424
		[CompilerGenerated]
		private sealed class c667dd7d578392b64f2ae1cb91ee6686a
		{
			// Token: 0x06001FA2 RID: 8098 RVA: 0x00144FCC File Offset: 0x001431CC
			public void c5b980dc62b2f1c4b7b77e1e2056cfed1()
			{
				object arg_44_0 = this.cdbac995d0b545ca0718574d33380e861.cb6ea3d298d68be569f5410cc290458d5.c12a7ad156cb9ad1cf39a52d76e06acb5;
				double num = (double)this.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.cca5ded226e650778b7fe76464af7cdcd / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(98060);
				c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(arg_44_0, cd26c1ed86899b91c17e61188444ccd80.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151020)));
				c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.cdbac995d0b545ca0718574d33380e861.cb6ea3d298d68be569f5410cc290458d5.c3f8ccec3c9716cc1310498718b64ea5e, c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c5b1995a63fedd9443b419598ca3ea08f, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151025), cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.cab75189cbbf8f77be131afc306254891), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154634)));
				c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.cdbac995d0b545ca0718574d33380e861.cb6ea3d298d68be569f5410cc290458d5.c58344346cb86ff408ae0809ed6c973c3, cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c084849f9701722a8a82ccb51e3567e62));
				c5f99a6dc6570d46ac2273d729a96f627.c30767ddca1f9c207888833aea5b5fc61(this.cdbac995d0b545ca0718574d33380e861.cb6ea3d298d68be569f5410cc290458d5.c647d1308c87f5348cfe144e6821c97b2, this.cdbac995d0b545ca0718574d33380e861.cb6ea3d298d68be569f5410cc290458d5.cccd5cbc3d8eb61a5107082cf91ebdbeb(this.caffc9c8c53b2b4e64387e4898a3dd6f9.ce1ed6a6cb7304463ffd824d14b62f430.c4059fe7fb67522e038fb94baf8150674));
			}

			// Token: 0x04001522 RID: 5410
			public cbf4111912aed594f2b4372828dd95aa3.c1b335898911b58d721104396217b5d94 cdbac995d0b545ca0718574d33380e861;

			// Token: 0x04001523 RID: 5411
			public AccTreeViewInfo caffc9c8c53b2b4e64387e4898a3dd6f9;
		}

		// Token: 0x02000591 RID: 1425
		[CompilerGenerated]
		private sealed class c8b3d85ac060012ebb4190ee9590fa377
		{
			// Token: 0x06001FA4 RID: 8100 RVA: 0x001450F4 File Offset: 0x001432F4
			public void c35fbfa1af1abb8ce8817e0715494acc7()
			{
				this.cb6ea3d298d68be569f5410cc290458d5.c27dd6fc0a36cf582997f24bf3bc5ff2e(this.c97bb0419a7a851c991e9e986b8e0f5c1);
			}

			// Token: 0x04001524 RID: 5412
			public AccTreeViewInfo c97bb0419a7a851c991e9e986b8e0f5c1;

			// Token: 0x04001525 RID: 5413
			public cbf4111912aed594f2b4372828dd95aa3 cb6ea3d298d68be569f5410cc290458d5;
		}

		// Token: 0x02000592 RID: 1426
		[CompilerGenerated]
		private sealed class c42fc2c3d20f7176b8dfba4608d506523
		{
			// Token: 0x04001526 RID: 5414
			public cbf4111912aed594f2b4372828dd95aa3 cb6ea3d298d68be569f5410cc290458d5;

			// Token: 0x04001527 RID: 5415
			public AccTreeViewInfo cdc42dd0acc0401cea523023c11463c96;
		}

		// Token: 0x02000593 RID: 1427
		[CompilerGenerated]
		private sealed class c9274186166aa974ae7c5bdefc671df92
		{
			// Token: 0x06001FA7 RID: 8103 RVA: 0x0014513C File Offset: 0x0014333C
			public void cc34013a2a94bbcde751e5e5cda155439()
			{
				c41303f5801b83831668dac7d66691e12 c41303f5801b83831668dac7d66691e = new c41303f5801b83831668dac7d66691e12();
				c41303f5801b83831668dac7d66691e.cdc42dd0acc0401cea523023c11463c96 = this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96;
				c41303f5801b83831668dac7d66691e.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 = this.c8a12ec6aaaa9d79fcdc7c5dabdc3e283;
				if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, ""))
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!true)
					{
						RuntimeMethodHandle arg_58_0 = methodof(cbf4111912aed594f2b4372828dd95aa3.c9274186166aa974ae7c5bdefc671df92.cc34013a2a94bbcde751e5e5cda155439()).MethodHandle;
					}
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150361), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(101258))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
					return;
				}
				long num = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98068);
				string cb5466a044809fda944eb67b4c5d2c8f = this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6;
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98072); i < c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(cb5466a044809fda944eb67b4c5d2c8f); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98080))
				{
					char c = c23ddf164d9a749977276969d2ff00afa.c30767ddca1f9c207888833aea5b5fc61(cb5466a044809fda944eb67b4c5d2c8f, i);
					num *= (long)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98076) + (int)c);
				}
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				long num2 = this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cf87a97659111f1d1252f7e39bcac0605 * num;
				if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153707)))
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					string text = "";
					string text2 = "";
					if (!this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c9a96b509d78182d92ce8572154236be3(c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203037), this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203154), this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.caee1e47a08a4ecec009fb2516f979104), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203175), c41303f5801b83831668dac7d66691e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98084) != 0))
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						return;
					}
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c5f93cb3d18e7f9a9cbbbc10374f403be, ""))
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150361), c41303f5801b83831668dac7d66691e.c5f93cb3d18e7f9a9cbbbc10374f403be), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
						return;
					}
					if (!this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c9a96b509d78182d92ce8572154236be3(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203224), c41303f5801b83831668dac7d66691e.c668c9290d4eea86e1d25b03108451ae9), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203309), c41303f5801b83831668dac7d66691e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98088) != 0))
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						return;
					}
					if (!this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c9a96b509d78182d92ce8572154236be3(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203364), c41303f5801b83831668dac7d66691e.cefadbd31843b23ae8080afc73c57d963, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203483)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203566), c41303f5801b83831668dac7d66691e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98092) != 0))
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
						return;
					}
					if (!this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c482aa30397ad6ceec1a3b39772286af3(c41303f5801b83831668dac7d66691e.c4537e7e4f0525300135b26662a8d3802, c41303f5801b83831668dac7d66691e))
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						return;
					}
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c87cf43c19dbc8576e89b476a3d5b5f07(ref text, ref text2, num2);
					if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, ""))
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138673)))
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, ""))
							{
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
								if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138673)))
								{
									while (true)
									{
										switch (7)
										{
										case 0:
											continue;
										}
										break;
									}
								}
								else
								{
									cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203716), text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35582), text2));
									cbf4111912aed594f2b4372828dd95aa3 arg_509_0 = this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5;
									string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98096));
									array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98100)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203793);
									array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98104)] = text;
									array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98108)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203898);
									array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98112)] = text2;
									array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98116)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203921);
									array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98120)] = c41303f5801b83831668dac7d66691e.c8f2edca2205ab5c12cc2807d07b62388;
									array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98124)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203960);
									if (!arg_509_0.c9a96b509d78182d92ce8572154236be3(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204015), c41303f5801b83831668dac7d66691e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98128) != 0))
									{
										while (true)
										{
											switch (3)
											{
											case 0:
												continue;
											}
											break;
										}
										return;
									}
									if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.cf814b04482d1c4f2e113abe596b1a4ab, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204094)))
									{
										while (true)
										{
											switch (3)
											{
											case 0:
												continue;
											}
											break;
										}
										this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(99748))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
										return;
									}
									cbf4111912aed594f2b4372828dd95aa3 arg_672_0 = this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5;
									string[] array2 = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98132));
									array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98136)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204101);
									array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98140)] = text;
									array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98144)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203898);
									array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98148)] = text2;
									array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98152)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204309);
									array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98156)] = c41303f5801b83831668dac7d66691e.c8f2edca2205ab5c12cc2807d07b62388;
									array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98160)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204326);
									if (!arg_672_0.c9a96b509d78182d92ce8572154236be3(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204409), c41303f5801b83831668dac7d66691e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98164) != 0))
									{
										while (true)
										{
											switch (3)
											{
											case 0:
												continue;
											}
											break;
										}
										return;
									}
									if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c0b458c84121686eddf965dbd8a522b60, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204498)))
									{
										while (true)
										{
											switch (7)
											{
											case 0:
												continue;
											}
											break;
										}
										string text3 = c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(109181)));
										if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c0b458c84121686eddf965dbd8a522b60, ""))
										{
											while (true)
											{
												switch (5)
												{
												case 0:
													continue;
												}
												break;
											}
											if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c75a61b9b1579790f1c9d1020afc9b45b, ""))
											{
												while (true)
												{
													switch (4)
													{
													case 0:
														continue;
													}
													break;
												}
												string text4 = text3;
												string[] array3 = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98168));
												array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98172)] = text4;
												array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98176)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150358);
												array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98180)] = c41303f5801b83831668dac7d66691e.c0b458c84121686eddf965dbd8a522b60;
												array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98184)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154503);
												array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98188)] = c41303f5801b83831668dac7d66691e.c75a61b9b1579790f1c9d1020afc9b45b;
												text3 = c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array3);
											}
										}
										text3 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text3, cc5738ad72def28ae6b9bc70aa133668e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
										this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(text3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
										this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.cc442622fc18861728248f70298b36dc7 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98192) != 0);
										return;
									}
									if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c0b458c84121686eddf965dbd8a522b60, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204505)))
									{
										while (true)
										{
											switch (3)
											{
											case 0:
												continue;
											}
											break;
										}
										while (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.ce9cc237e4092e91790e871377df43e68, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(163551)))
										{
											string text5 = this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c3309aae1199d58439a8a86a478d6fab2(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98196));
											if (!this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c016fe8ab8aacac01131bd5bbb8bfcf24(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204512), text5), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204525), c41303f5801b83831668dac7d66691e, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204640), c41303f5801b83831668dac7d66691e.c8f2edca2205ab5c12cc2807d07b62388)))
											{
												while (true)
												{
													switch (7)
													{
													case 0:
														continue;
													}
													break;
												}
												return;
											}
											if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.ce9cc237e4092e91790e871377df43e68, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(163551)))
											{
												while (true)
												{
													switch (3)
													{
													case 0:
														continue;
													}
													break;
												}
												if (!this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c7706c5496c55fcaef4e39266f0529a16(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204683), text5), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204702), c41303f5801b83831668dac7d66691e, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204640), c41303f5801b83831668dac7d66691e.c8f2edca2205ab5c12cc2807d07b62388)))
												{
													while (true)
													{
														switch (7)
														{
														case 0:
															continue;
														}
														break;
													}
													return;
												}
												cbf4111912aed594f2b4372828dd95aa3 arg_9E8_0 = this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5;
												string[] array4 = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98200));
												array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98204)] = this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6;
												array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98208)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
												array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98212)] = AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(99070));
												array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98216)] = text5;
												array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98220)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34642);
												arg_9E8_0.c8299fa31317d146976f1ea9cd623369b(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array4), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
												cbf4111912aed594f2b4372828dd95aa3 arg_AC0_0 = this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5;
												array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98224));
												array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98228)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204101);
												array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98232)] = text;
												array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98236)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203898);
												array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98240)] = text2;
												array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98244)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204309);
												array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98248)] = c41303f5801b83831668dac7d66691e.c8f2edca2205ab5c12cc2807d07b62388;
												array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98252)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204793);
												if (!arg_AC0_0.c9a96b509d78182d92ce8572154236be3(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204409), c41303f5801b83831668dac7d66691e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98256) != 0))
												{
													while (true)
													{
														switch (3)
														{
														case 0:
															continue;
														}
														break;
													}
													return;
												}
											}
										}
										while (true)
										{
											switch (1)
											{
											case 0:
												continue;
											}
											break;
										}
									}
									if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c405e537f1c0f9ad0df4db23b46591ea7, ""))
									{
										while (true)
										{
											switch (6)
											{
											case 0:
												continue;
											}
											break;
										}
										if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c03f8978984671fce959e74a1d566ffa6, ""))
										{
											while (true)
											{
												switch (1)
												{
												case 0:
													continue;
												}
												break;
											}
											cec4dc845e772c3e699a057c528837cac.c36f14603976d7f8bddf05cfac99c0409 c36f14603976d7f8bddf05cfac99c = default(cec4dc845e772c3e699a057c528837cac.c36f14603976d7f8bddf05cfac99c0409);
											cec4dc845e772c3e699a057c528837cac.cca57fc0ef865e600cc3c5551dbbb1b49 cca57fc0ef865e600cc3c5551dbbb1b = default(cec4dc845e772c3e699a057c528837cac.cca57fc0ef865e600cc3c5551dbbb1b49);
											if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c1ded6f4a88323e98679c6ecfe003d120())
											{
												while (true)
												{
													switch (4)
													{
													case 0:
														continue;
													}
													break;
												}
												cca57fc0ef865e600cc3c5551dbbb1b.ca454189d5a2c20a689cc7ef5f5e6702e = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98260);
												cca57fc0ef865e600cc3c5551dbbb1b.ca0e10f3da44c51d0b196382221e3daa3 = (short)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98264);
											}
											cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918 structure = default(cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918);
											cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918 structure2 = default(cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918);
											structure.c58fa9f2670ab99f3e9f95f527de60cb5 = Marshal.SizeOf<cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918>(structure);
											structure2.c58fa9f2670ab99f3e9f95f527de60cb5 = Marshal.SizeOf<cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918>(structure2);
											string text6 = c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204800), c41303f5801b83831668dac7d66691e.c405e537f1c0f9ad0df4db23b46591ea7, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204875), c41303f5801b83831668dac7d66691e.c03f8978984671fce959e74a1d566ffa6);
											if (!AppMain.stealthMode)
											{
												while (true)
												{
													switch (4)
													{
													case 0:
														continue;
													}
													break;
												}
												this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c3997da75761c4b628d031359dc2a7bd8();
											}
											if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c3d6b0f96be8253400b50cd1940ff88cc(), ""))
											{
												while (true)
												{
													switch (3)
													{
													case 0:
														continue;
													}
													break;
												}
												if (cc4987d6a853db77954f21abe4e42946a.ca85cf98296ef69d0d4df9e492e1d2df3((ClientVersion)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98268), AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c3d6b0f96be8253400b50cd1940ff88cc()))
												{
													goto IL_CF8;
												}
												while (true)
												{
													switch (7)
													{
													case 0:
														continue;
													}
													break;
												}
											}
											string text7 = cc4987d6a853db77954f21abe4e42946a.c2e4607f4d0db70f1d5fccef8022d1220((ClientVersion)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98272));
											if (!c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text7, ""))
											{
												this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150361), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(103488))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
												return;
											}
											while (true)
											{
												switch (5)
												{
												case 0:
													continue;
												}
												break;
											}
											AppMain.ca691be15ac02d2fd13604941dfb1f495.set_c3d6b0f96be8253400b50cd1940ff88cc(text7);
											AppMain.c1a2627f895092b3cf57a9486ed72ee32.c7b070de9818d805d16cb0fc6a02ae127();
											IL_CF8:
											using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(AppMain.cdf464e19f0e36e472601336aa05e5d18.c688486d1a0a6459b5dd3db4ad6e7cebd))
											{
												this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.ce6c2e2a9c87da36d51d1e5342fd20ef8((ClientVersion)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98276));
												if (!AppMain.stealthMode)
												{
													while (true)
													{
														switch (4)
														{
														case 0:
															continue;
														}
														break;
													}
													cec4dc845e772c3e699a057c528837cac.c5cc8ff7c3c829e04a02c2ea76624fe34(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c3d6b0f96be8253400b50cd1940ff88cc(), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204892)), text6, ref structure, ref structure2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98280) != 0, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98284), IntPtr.Zero, null, ref cca57fc0ef865e600cc3c5551dbbb1b, out c36f14603976d7f8bddf05cfac99c);
													AppMain.cdf464e19f0e36e472601336aa05e5d18.c5b8a8ab26ef0e29e7173cb4e2915e2d6(c591b3807e3508f06381b8edb380d1130.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c36f14603976d7f8bddf05cfac99c.ccc1b6474af18a76c36a3ba11d663bf35), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98288) != 0);
													cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(38874)));
													this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9 = AppMain.cdf464e19f0e36e472601336aa05e5d18.c8212c323cbad2bba6c6c5da4ae324873(c36f14603976d7f8bddf05cfac99c.ccc1b6474af18a76c36a3ba11d663bf35, c36f14603976d7f8bddf05cfac99c.c46f2a4ad19b1705266ba99a93e7f5e6b, this.c8a12ec6aaaa9d79fcdc7c5dabdc3e283, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98292) != 0, this.cf7f9dd41b0e6b39e2c5be23b31594c5c, this.c0e7f2605098a287d665d29e90ff19981, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204931), this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96, AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c3d6b0f96be8253400b50cd1940ff88cc());
													this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9.add_c03506d53ef036c610d91b5dc70db4303(new CoreInternal.c30073906c1647fb672cf43ea83304097(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.c5a90aef26704b6b306717a50c7b22b73));
												}
												else
												{
													List<c3588145757b357d2914eb656b313ecae> list = AppMain.c184a42a74d25a49281e3c84092602419.c39c4123f5a98f990da5c03fbbe3eb316();
													if (cb60f82a4d3832ddd94abec4b7cb495ce.c30767ddca1f9c207888833aea5b5fc61(list) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98296))
													{
														while (true)
														{
															switch (5)
															{
															case 0:
																continue;
															}
															break;
														}
														bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98300) != 0;
														try
														{
															object ce7afbb9027bf2feb71f836f6a31f2d;
															cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d = c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98304)).ce7afbb9027bf2feb71f836f6a31f2d37, ref flag);
															c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98308)).ce0db3e4869f83e785fd6b3f882c2ad50 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98312);
															c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98316)).ca8123d02877c101ca9d6878779e5867f = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98320);
															ca081a66cee3bf2dcb0f3ee208852b645.c30767ddca1f9c207888833aea5b5fc61(c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98324)).cc2cf678c05af30b3d1766fa545d867c1, new cd445a92e0179756ff5aa0012c46629ad(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c3d6b0f96be8253400b50cd1940ff88cc(), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204958), text6)).c442e09b1de2262d3a3a28826b3ea696f());
															long num3 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
															while (num3 + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98340) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
															{
																c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98328));
																if (c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98332)).ce0db3e4869f83e785fd6b3f882c2ad50 != 0)
																{
																	while (true)
																	{
																		switch (6)
																		{
																		case 0:
																			continue;
																		}
																		break;
																	}
																	if (c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98336)).ca8123d02877c101ca9d6878779e5867f != 0)
																	{
																		IL_FCB:
																		cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(38874)));
																		this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9 = AppMain.cdf464e19f0e36e472601336aa05e5d18.c8212c323cbad2bba6c6c5da4ae324873(c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98344)).ca8123d02877c101ca9d6878779e5867f, c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98348)).ce0db3e4869f83e785fd6b3f882c2ad50, this.c8a12ec6aaaa9d79fcdc7c5dabdc3e283, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98352) != 0, this.cf7f9dd41b0e6b39e2c5be23b31594c5c, this.c0e7f2605098a287d665d29e90ff19981, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204931), this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96, AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c3d6b0f96be8253400b50cd1940ff88cc());
																		this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9.add_c03506d53ef036c610d91b5dc70db4303(new CoreInternal.c30073906c1647fb672cf43ea83304097(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.c5a90aef26704b6b306717a50c7b22b73));
																		goto IL_10B6;
																	}
																	while (true)
																	{
																		switch (1)
																		{
																		case 0:
																			continue;
																		}
																		break;
																	}
																}
															}
															while (true)
															{
																switch (5)
																{
																case 0:
																	continue;
																}
																goto IL_FCB;
															}
														}
														finally
														{
															if (flag)
															{
																while (true)
																{
																	switch (5)
																	{
																	case 0:
																		continue;
																	}
																	break;
																}
																object ce7afbb9027bf2feb71f836f6a31f2d;
																c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d);
															}
														}
													}
												}
												IL_10B6:;
											}
											this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(98386))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
											return;
										}
									}
									string text8 = c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(98784)));
									if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c0b458c84121686eddf965dbd8a522b60, ""))
									{
										while (true)
										{
											switch (3)
											{
											case 0:
												continue;
											}
											break;
										}
										if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.c75a61b9b1579790f1c9d1020afc9b45b, ""))
										{
											while (true)
											{
												switch (1)
												{
												case 0:
													continue;
												}
												break;
											}
											string text4 = text8;
											array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98356));
											array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98360)] = text4;
											array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98364)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150358);
											array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98368)] = c41303f5801b83831668dac7d66691e.c0b458c84121686eddf965dbd8a522b60;
											array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98372)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(154503);
											array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98376)] = c41303f5801b83831668dac7d66691e.c75a61b9b1579790f1c9d1020afc9b45b;
											text8 = c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array);
										}
									}
									text8 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text8, cc5738ad72def28ae6b9bc70aa133668e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
									this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(text8, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
									return;
								}
							}
						}
					}
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203651)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
					return;
				}
				else if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153667)))
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					byte[] array5 = c6f443db75f880bf749031aa549897119.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num2);
					string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98380));
					string[] arg_12F3_0 = array;
					int arg_12F3_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98384);
					int num4 = (int)(array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98388)] ^ array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98392)]);
					arg_12F3_0[arg_12F3_1] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
					string[] arg_1332_0 = array;
					int arg_1332_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98396);
					num4 = (int)(array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98400)] ^ array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98404)]);
					arg_1332_0[arg_1332_1] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
					string[] arg_1371_0 = array;
					int arg_1371_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98408);
					num4 = (int)(array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98412)] ^ array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98416)]);
					arg_1371_0[arg_1371_1] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
					string[] arg_13B0_0 = array;
					int arg_13B0_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98420);
					num4 = (int)(array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98424)] ^ array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98428)]);
					arg_13B0_0[arg_13B0_1] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
					string[] arg_13EF_0 = array;
					int arg_13EF_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98432);
					num4 = (int)(array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98436)] ^ array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98440)]);
					arg_13EF_0[arg_13EF_1] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
					string[] arg_142E_0 = array;
					int arg_142E_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98444);
					num4 = (int)(array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98448)] ^ array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98452)]);
					arg_142E_0[arg_142E_1] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
					string text9 = c35684689f284b0dfa046ebcdcbc9fc5f.c30767ddca1f9c207888833aea5b5fc61(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array));
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204999), text9));
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.ce7b7bd1b30026b9b60631aeecc14a23e(c41303f5801b83831668dac7d66691e);
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c9184c74f25dab65adf90c873d9a7fdfb(c41303f5801b83831668dac7d66691e);
					if (!this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c99702ea1139ca53449d4279abb433732(c41303f5801b83831668dac7d66691e))
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205036)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
						return;
					}
					cbf4111912aed594f2b4372828dd95aa3 arg_15ED_0 = this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5;
					array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98456));
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98460)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205085);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98464)] = c8da62f54b736d40009f0d8f6e67bef11.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98468)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203154);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98472)] = c8da62f54b736d40009f0d8f6e67bef11.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.caee1e47a08a4ecec009fb2516f979104);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98476)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205104);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98480)] = this.c89ca75054b1fbd963984dc44a4afd9c0;
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98484)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205123);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98488)] = text9;
					if (!arg_15ED_0.c02dadf815997d3bbbc04bc40361b41a7(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205210), c41303f5801b83831668dac7d66691e))
					{
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
						if (c41303f5801b83831668dac7d66691e.c7b389d4ea5b6049ba644f5a877e42072)
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									continue;
								}
								break;
							}
							cbf4111912aed594f2b4372828dd95aa3.c9274186166aa974ae7c5bdefc671df92.c1f75a77c25eb1ab41e6dff3f8d5732b5 c1f75a77c25eb1ab41e6dff3f8d5732b = new cbf4111912aed594f2b4372828dd95aa3.c9274186166aa974ae7c5bdefc671df92.c1f75a77c25eb1ab41e6dff3f8d5732b5();
							c1f75a77c25eb1ab41e6dff3f8d5732b.c8475b979f583351cce825a43e895c342 = this;
							c1f75a77c25eb1ab41e6dff3f8d5732b.c768dcb1024d7c851c6be8448d9e02a5a = this.c768dcb1024d7c851c6be8448d9e02a5a;
							c1f75a77c25eb1ab41e6dff3f8d5732b.c75caea119109a1c6a383d45205ff13b4 = "";
							c945f8c0caac6afd3e423205e93db941b.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c30767ddca1f9c207888833aea5b5fc61(this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397), new Action(c1f75a77c25eb1ab41e6dff3f8d5732b.cc81f58610ff6f780b96aa509b5f10ecb));
							if (c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(c1f75a77c25eb1ab41e6dff3f8d5732b.c75caea119109a1c6a383d45205ff13b4) <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98492))
							{
								this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(98784))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
								return;
							}
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							c1f75a77c25eb1ab41e6dff3f8d5732b.c75caea119109a1c6a383d45205ff13b4 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(c1f75a77c25eb1ab41e6dff3f8d5732b.c75caea119109a1c6a383d45205ff13b4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205297), "");
							cbf4111912aed594f2b4372828dd95aa3 arg_17EF_0 = this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5;
							array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98496));
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98500)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205085);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98504)] = c8da62f54b736d40009f0d8f6e67bef11.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98508)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203154);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98512)] = c8da62f54b736d40009f0d8f6e67bef11.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.caee1e47a08a4ecec009fb2516f979104);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98516)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205104);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98520)] = this.c89ca75054b1fbd963984dc44a4afd9c0;
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98524)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205300);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98528)] = c1f75a77c25eb1ab41e6dff3f8d5732b.c75caea119109a1c6a383d45205ff13b4;
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98532)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205383);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98536)] = text9;
							if (!arg_17EF_0.c02dadf815997d3bbbc04bc40361b41a7(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205210), c41303f5801b83831668dac7d66691e))
							{
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									break;
								}
								this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(98784))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
								this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.ccb2c415213d47537af44476338eb3e7e = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98540) != 0);
								return;
							}
						}
						else
						{
							if (c41303f5801b83831668dac7d66691e.cd863c162c62aa74d7467903f06abd2c5)
							{
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									break;
								}
								this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(109181))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
								this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.cc442622fc18861728248f70298b36dc7 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98544) != 0);
								return;
							}
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(98784))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
							this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.ccb2c415213d47537af44476338eb3e7e = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98548) != 0);
							return;
						}
					}
					if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.cbab51a48bb652077efbc1d16e7db1697, ""))
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.cf7fc9669e7e05a29179b2df480fb1c86, ""))
						{
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.ce1349517f2a0d77011a835bf5356ab9f(c41303f5801b83831668dac7d66691e);
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cf6f5a9939957cdc588fa6e807fd553fa(c41303f5801b83831668dac7d66691e);
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.ce29d501176cac41bb18d4ce01c3cc625(c41303f5801b83831668dac7d66691e);
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c14731e59c821a2f13c03c544e2bbd309(c41303f5801b83831668dac7d66691e);
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c14731e59c821a2f13c03c544e2bbd309(c41303f5801b83831668dac7d66691e);
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cc0f65d69734f191efe96f147a2cf9626(c41303f5801b83831668dac7d66691e);
							uint num5 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98552);
							uint num6 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98556);
							byte[] array6 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c41303f5801b83831668dac7d66691e.cbab51a48bb652077efbc1d16e7db1697);
							byte[] array7 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c41303f5801b83831668dac7d66691e.cf7fc9669e7e05a29179b2df480fb1c86);
							byte[] array8 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array6) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98560) + (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array7));
							cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array7, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98564), array8, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98568), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array7));
							array8[(int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array7)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98572);
							cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array6, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98576), array8, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array7) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98580), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array6));
							if (!AppMain.stealthMode)
							{
								while (true)
								{
									switch (6)
									{
									case 0:
										continue;
									}
									break;
								}
								cec4dc845e772c3e699a057c528837cac.c60dea235214869c7c4752ed5d1e1579b(array8, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array8), array7, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array7), ref num5, ref num6);
							}
							cec4dc845e772c3e699a057c528837cac.c36f14603976d7f8bddf05cfac99c0409 c36f14603976d7f8bddf05cfac99c2 = default(cec4dc845e772c3e699a057c528837cac.c36f14603976d7f8bddf05cfac99c0409);
							cec4dc845e772c3e699a057c528837cac.cca57fc0ef865e600cc3c5551dbbb1b49 cca57fc0ef865e600cc3c5551dbbb1b2 = default(cec4dc845e772c3e699a057c528837cac.cca57fc0ef865e600cc3c5551dbbb1b49);
							if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c1ded6f4a88323e98679c6ecfe003d120())
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								cca57fc0ef865e600cc3c5551dbbb1b2.ca454189d5a2c20a689cc7ef5f5e6702e = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98584);
								cca57fc0ef865e600cc3c5551dbbb1b2.ca0e10f3da44c51d0b196382221e3daa3 = (short)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98588);
							}
							cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918 structure3 = default(cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918);
							cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918 structure4 = default(cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918);
							structure3.c58fa9f2670ab99f3e9f95f527de60cb5 = Marshal.SizeOf<cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918>(structure3);
							structure4.c58fa9f2670ab99f3e9f95f527de60cb5 = Marshal.SizeOf<cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918>(structure4);
							string text10 = this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb985061242b7c893cd2fde331e41a62a;
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text10, ""))
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									break;
								}
								text10 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205402);
							}
							string text11;
							if (!AppMain.stealthMode)
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c3997da75761c4b628d031359dc2a7bd8();
								array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98592));
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98596)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205413);
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98600)] = c9cfd598d1712a6220818729a2a2659e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num5, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34364));
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98604)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98608)] = c9cfd598d1712a6220818729a2a2659e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34364));
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98612)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205520);
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98616)] = text10;
								text11 = c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array);
							}
							else
							{
								text11 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205559), text10);
							}
							if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_cc9c5571bcb54c3374eb7ab47c11831fb(), ""))
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								if (cc4987d6a853db77954f21abe4e42946a.ca85cf98296ef69d0d4df9e492e1d2df3((ClientVersion)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98620), AppMain.ca691be15ac02d2fd13604941dfb1f495.get_cc9c5571bcb54c3374eb7ab47c11831fb()))
								{
									goto IL_1EA2;
								}
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									break;
								}
							}
							string text12 = cc4987d6a853db77954f21abe4e42946a.c2e4607f4d0db70f1d5fccef8022d1220((ClientVersion)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98624));
							if (!c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text12, ""))
							{
								this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150361), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(103488))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
								return;
							}
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							AppMain.ca691be15ac02d2fd13604941dfb1f495.set_cc9c5571bcb54c3374eb7ab47c11831fb(text12);
							AppMain.c1a2627f895092b3cf57a9486ed72ee32.c7b070de9818d805d16cb0fc6a02ae127();
							IL_1EA2:
							using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(AppMain.cdf464e19f0e36e472601336aa05e5d18.c688486d1a0a6459b5dd3db4ad6e7cebd))
							{
								this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.ce6c2e2a9c87da36d51d1e5342fd20ef8((ClientVersion)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98628));
								if (!AppMain.stealthMode)
								{
									while (true)
									{
										switch (2)
										{
										case 0:
											continue;
										}
										break;
									}
									cec4dc845e772c3e699a057c528837cac.c5cc8ff7c3c829e04a02c2ea76624fe34(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_cc9c5571bcb54c3374eb7ab47c11831fb(), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204892)), text11, ref structure3, ref structure4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98632) != 0, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98636), IntPtr.Zero, null, ref cca57fc0ef865e600cc3c5551dbbb1b2, out c36f14603976d7f8bddf05cfac99c2);
									AppMain.cdf464e19f0e36e472601336aa05e5d18.c5b8a8ab26ef0e29e7173cb4e2915e2d6(c591b3807e3508f06381b8edb380d1130.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c36f14603976d7f8bddf05cfac99c2.ccc1b6474af18a76c36a3ba11d663bf35), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98640) != 0);
									cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(38874)));
									this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9 = AppMain.cdf464e19f0e36e472601336aa05e5d18.c8212c323cbad2bba6c6c5da4ae324873(c36f14603976d7f8bddf05cfac99c2.ccc1b6474af18a76c36a3ba11d663bf35, c36f14603976d7f8bddf05cfac99c2.c46f2a4ad19b1705266ba99a93e7f5e6b, this.c8a12ec6aaaa9d79fcdc7c5dabdc3e283, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98644) != 0, this.cf7f9dd41b0e6b39e2c5be23b31594c5c, this.c0e7f2605098a287d665d29e90ff19981, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205739), this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96, AppMain.ca691be15ac02d2fd13604941dfb1f495.get_cc9c5571bcb54c3374eb7ab47c11831fb());
									this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9.add_c03506d53ef036c610d91b5dc70db4303(new CoreInternal.c30073906c1647fb672cf43ea83304097(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.c5a90aef26704b6b306717a50c7b22b73));
								}
								else
								{
									List<c3588145757b357d2914eb656b313ecae> list2 = AppMain.c184a42a74d25a49281e3c84092602419.c39c4123f5a98f990da5c03fbbe3eb316();
									if (cb60f82a4d3832ddd94abec4b7cb495ce.c30767ddca1f9c207888833aea5b5fc61(list2) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98648))
									{
										while (true)
										{
											switch (7)
											{
											case 0:
												continue;
											}
											break;
										}
										bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98652) != 0;
										try
										{
											object ce7afbb9027bf2feb71f836f6a31f2d;
											cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d = c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98656)).ce7afbb9027bf2feb71f836f6a31f2d37, ref flag2);
											c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98660)).ce0db3e4869f83e785fd6b3f882c2ad50 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98664);
											c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98668)).ca8123d02877c101ca9d6878779e5867f = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98672);
											ca081a66cee3bf2dcb0f3ee208852b645.c30767ddca1f9c207888833aea5b5fc61(c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98676)).cc2cf678c05af30b3d1766fa545d867c1, new ca8854b46c089fdef00095522a8028d6c(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_cc9c5571bcb54c3374eb7ab47c11831fb(), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204958), text11), array8, array7).c442e09b1de2262d3a3a28826b3ea696f());
											long num7 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
											while (num7 + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98692) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
											{
												c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98680));
												if (c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98684)).ce0db3e4869f83e785fd6b3f882c2ad50 != 0)
												{
													while (true)
													{
														switch (7)
														{
														case 0:
															continue;
														}
														break;
													}
													if (c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98688)).ca8123d02877c101ca9d6878779e5867f != 0)
													{
														IL_2179:
														cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(38874)));
														this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9 = AppMain.cdf464e19f0e36e472601336aa05e5d18.c8212c323cbad2bba6c6c5da4ae324873(c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98696)).ca8123d02877c101ca9d6878779e5867f, c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98700)).ce0db3e4869f83e785fd6b3f882c2ad50, this.c8a12ec6aaaa9d79fcdc7c5dabdc3e283, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98704) != 0, this.cf7f9dd41b0e6b39e2c5be23b31594c5c, this.c0e7f2605098a287d665d29e90ff19981, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205739), this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96, AppMain.ca691be15ac02d2fd13604941dfb1f495.get_cc9c5571bcb54c3374eb7ab47c11831fb());
														this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9.add_c03506d53ef036c610d91b5dc70db4303(new CoreInternal.c30073906c1647fb672cf43ea83304097(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.c5a90aef26704b6b306717a50c7b22b73));
														goto IL_2264;
													}
													while (true)
													{
														switch (5)
														{
														case 0:
															continue;
														}
														break;
													}
												}
											}
											while (true)
											{
												switch (2)
												{
												case 0:
													continue;
												}
												goto IL_2179;
											}
										}
										finally
										{
											if (flag2)
											{
												while (true)
												{
													switch (7)
													{
													case 0:
														continue;
													}
													break;
												}
												object ce7afbb9027bf2feb71f836f6a31f2d;
												c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d);
											}
										}
									}
								}
								IL_2264:;
							}
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(98386))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
							return;
						}
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(99748))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
					return;
				}
				else
				{
					if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.c55c27af638ad45a0b38f2eaa2329a4c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153680)))
					{
						this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150361), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(101572))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
						return;
					}
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					byte[] array9 = c6f443db75f880bf749031aa549897119.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num2);
					string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98708));
					string[] arg_2363_0 = array;
					int arg_2363_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98712);
					int num4 = (int)(array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98716)] ^ array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98720)]);
					arg_2363_0[arg_2363_1] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
					string[] arg_23A2_0 = array;
					int arg_23A2_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98724);
					num4 = (int)(array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98728)] ^ array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98732)]);
					arg_23A2_0[arg_23A2_1] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
					string[] arg_23E1_0 = array;
					int arg_23E1_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98736);
					num4 = (int)(array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98740)] ^ array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98744)]);
					arg_23E1_0[arg_23E1_1] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
					string[] arg_2420_0 = array;
					int arg_2420_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98748);
					num4 = (int)(array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98752)] ^ array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98756)]);
					arg_2420_0[arg_2420_1] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
					string[] arg_245F_0 = array;
					int arg_245F_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98760);
					num4 = (int)(array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98764)] ^ array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98768)]);
					arg_245F_0[arg_245F_1] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
					string[] arg_249E_0 = array;
					int arg_249E_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98772);
					num4 = (int)(array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98776)] ^ array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98780)]);
					arg_249E_0[arg_249E_1] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
					string text13 = c35684689f284b0dfa046ebcdcbc9fc5f.c30767ddca1f9c207888833aea5b5fc61(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array));
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204999), text13));
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.ce7b7bd1b30026b9b60631aeecc14a23e(c41303f5801b83831668dac7d66691e);
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c9184c74f25dab65adf90c873d9a7fdfb(c41303f5801b83831668dac7d66691e);
					if (!this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c99702ea1139ca53449d4279abb433732(c41303f5801b83831668dac7d66691e))
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205036)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
						return;
					}
					cbf4111912aed594f2b4372828dd95aa3 arg_265D_0 = this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5;
					array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98784));
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98788)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205085);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98792)] = c8da62f54b736d40009f0d8f6e67bef11.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98796)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203154);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98800)] = c8da62f54b736d40009f0d8f6e67bef11.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.caee1e47a08a4ecec009fb2516f979104);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98804)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205104);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98808)] = this.c89ca75054b1fbd963984dc44a4afd9c0;
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98812)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205123);
					array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98816)] = text13;
					if (!arg_265D_0.c02dadf815997d3bbbc04bc40361b41a7(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205210), c41303f5801b83831668dac7d66691e))
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						if (c41303f5801b83831668dac7d66691e.c7b389d4ea5b6049ba644f5a877e42072)
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							cbf4111912aed594f2b4372828dd95aa3.c9274186166aa974ae7c5bdefc671df92.c2586ec3ff99991d1afc054c7dc5437d3 c2586ec3ff99991d1afc054c7dc5437d = new cbf4111912aed594f2b4372828dd95aa3.c9274186166aa974ae7c5bdefc671df92.c2586ec3ff99991d1afc054c7dc5437d3();
							c2586ec3ff99991d1afc054c7dc5437d.c8475b979f583351cce825a43e895c342 = this;
							c2586ec3ff99991d1afc054c7dc5437d.c768dcb1024d7c851c6be8448d9e02a5a = this.c768dcb1024d7c851c6be8448d9e02a5a;
							c2586ec3ff99991d1afc054c7dc5437d.c75caea119109a1c6a383d45205ff13b4 = "";
							c945f8c0caac6afd3e423205e93db941b.c30767ddca1f9c207888833aea5b5fc61(ce430ef4c9c97ad6b9f660180ee5ee436.c30767ddca1f9c207888833aea5b5fc61(this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397), new Action(c2586ec3ff99991d1afc054c7dc5437d.c3472f1ab295e2ddf76eda6879eccc099));
							if (c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(c2586ec3ff99991d1afc054c7dc5437d.c75caea119109a1c6a383d45205ff13b4) <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98820))
							{
								this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(98784))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
								this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.ccb2c415213d47537af44476338eb3e7e = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98868) != 0);
								return;
							}
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							c2586ec3ff99991d1afc054c7dc5437d.c75caea119109a1c6a383d45205ff13b4 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(c2586ec3ff99991d1afc054c7dc5437d.c75caea119109a1c6a383d45205ff13b4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205297), "");
							cbf4111912aed594f2b4372828dd95aa3 arg_285F_0 = this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5;
							array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98824));
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98828)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205085);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98832)] = c8da62f54b736d40009f0d8f6e67bef11.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98836)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(203154);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98840)] = c8da62f54b736d40009f0d8f6e67bef11.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.caee1e47a08a4ecec009fb2516f979104);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98844)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205104);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98848)] = this.c89ca75054b1fbd963984dc44a4afd9c0;
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98852)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205300);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98856)] = c2586ec3ff99991d1afc054c7dc5437d.c75caea119109a1c6a383d45205ff13b4;
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98860)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205383);
							array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98864)] = text13;
							if (!arg_285F_0.c02dadf815997d3bbbc04bc40361b41a7(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205210), c41303f5801b83831668dac7d66691e))
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(98784))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
								return;
							}
						}
						else
						{
							if (c41303f5801b83831668dac7d66691e.cd863c162c62aa74d7467903f06abd2c5)
							{
								while (true)
								{
									switch (4)
									{
									case 0:
										continue;
									}
									break;
								}
								this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(109181))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
								this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.cc442622fc18861728248f70298b36dc7 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98872) != 0);
								return;
							}
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(98784))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
							this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.ccb2c415213d47537af44476338eb3e7e = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98876) != 0);
							return;
						}
					}
					if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.cbab51a48bb652077efbc1d16e7db1697, ""))
					{
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41303f5801b83831668dac7d66691e.cf7fc9669e7e05a29179b2df480fb1c86, ""))
						{
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.ce1349517f2a0d77011a835bf5356ab9f(c41303f5801b83831668dac7d66691e);
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cf6f5a9939957cdc588fa6e807fd553fa(c41303f5801b83831668dac7d66691e);
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.ce29d501176cac41bb18d4ce01c3cc625(c41303f5801b83831668dac7d66691e);
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c14731e59c821a2f13c03c544e2bbd309(c41303f5801b83831668dac7d66691e);
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c14731e59c821a2f13c03c544e2bbd309(c41303f5801b83831668dac7d66691e);
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cc0f65d69734f191efe96f147a2cf9626(c41303f5801b83831668dac7d66691e);
							uint num8 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98880);
							uint num9 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98884);
							byte[] array10 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c41303f5801b83831668dac7d66691e.cbab51a48bb652077efbc1d16e7db1697);
							byte[] array11 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c41303f5801b83831668dac7d66691e.cf7fc9669e7e05a29179b2df480fb1c86);
							byte[] array12 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array10) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98888) + (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array11));
							cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array11, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98892), array12, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98896), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array11));
							array12[(int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array11)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98900);
							cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array10, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98904), array12, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array11) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98908), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array10));
							if (!AppMain.stealthMode)
							{
								while (true)
								{
									switch (2)
									{
									case 0:
										continue;
									}
									break;
								}
								cec4dc845e772c3e699a057c528837cac.c60dea235214869c7c4752ed5d1e1579b(array12, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array12), array11, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array11), ref num8, ref num9);
							}
							cec4dc845e772c3e699a057c528837cac.c36f14603976d7f8bddf05cfac99c0409 c36f14603976d7f8bddf05cfac99c3 = default(cec4dc845e772c3e699a057c528837cac.c36f14603976d7f8bddf05cfac99c0409);
							cec4dc845e772c3e699a057c528837cac.cca57fc0ef865e600cc3c5551dbbb1b49 cca57fc0ef865e600cc3c5551dbbb1b3 = default(cec4dc845e772c3e699a057c528837cac.cca57fc0ef865e600cc3c5551dbbb1b49);
							if (AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c1ded6f4a88323e98679c6ecfe003d120())
							{
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									break;
								}
								cca57fc0ef865e600cc3c5551dbbb1b3.ca454189d5a2c20a689cc7ef5f5e6702e = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98912);
								cca57fc0ef865e600cc3c5551dbbb1b3.ca0e10f3da44c51d0b196382221e3daa3 = (short)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98916);
							}
							cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918 structure5 = default(cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918);
							cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918 structure6 = default(cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918);
							structure5.c58fa9f2670ab99f3e9f95f527de60cb5 = Marshal.SizeOf<cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918>(structure5);
							structure6.c58fa9f2670ab99f3e9f95f527de60cb5 = Marshal.SizeOf<cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918>(structure6);
							string text14 = this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb985061242b7c893cd2fde331e41a62a;
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text14, ""))
							{
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									break;
								}
								text14 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205402);
							}
							string text15;
							if (!AppMain.stealthMode)
							{
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									break;
								}
								this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c3997da75761c4b628d031359dc2a7bd8();
								array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98920));
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98924)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205770);
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98928)] = c9cfd598d1712a6220818729a2a2659e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num8, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34364));
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98932)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98936)] = c9cfd598d1712a6220818729a2a2659e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num9, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34364));
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98940)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205520);
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98944)] = text14;
								text15 = c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array);
							}
							else
							{
								text15 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(205871), text14);
							}
							if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c4227efd8356857d0af56cc4e83cdaee7(), ""))
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									break;
								}
								if (cc4987d6a853db77954f21abe4e42946a.ca85cf98296ef69d0d4df9e492e1d2df3((ClientVersion)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98948), AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c4227efd8356857d0af56cc4e83cdaee7()))
								{
									goto IL_2F12;
								}
								while (true)
								{
									switch (3)
									{
									case 0:
										continue;
									}
									break;
								}
							}
							string text16 = cc4987d6a853db77954f21abe4e42946a.c2e4607f4d0db70f1d5fccef8022d1220((ClientVersion)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98952));
							if (!c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text16, ""))
							{
								this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150361), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(103488))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
								return;
							}
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								break;
							}
							AppMain.ca691be15ac02d2fd13604941dfb1f495.set_c4227efd8356857d0af56cc4e83cdaee7(text16);
							AppMain.c1a2627f895092b3cf57a9486ed72ee32.c7b070de9818d805d16cb0fc6a02ae127();
							IL_2F12:
							using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(AppMain.cdf464e19f0e36e472601336aa05e5d18.c688486d1a0a6459b5dd3db4ad6e7cebd))
							{
								this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.ce6c2e2a9c87da36d51d1e5342fd20ef8((ClientVersion)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98956));
								if (!AppMain.stealthMode)
								{
									while (true)
									{
										switch (4)
										{
										case 0:
											continue;
										}
										break;
									}
									cec4dc845e772c3e699a057c528837cac.c5cc8ff7c3c829e04a02c2ea76624fe34(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c4227efd8356857d0af56cc4e83cdaee7(), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204892)), text15, ref structure5, ref structure6, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98960) != 0, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98964), IntPtr.Zero, null, ref cca57fc0ef865e600cc3c5551dbbb1b3, out c36f14603976d7f8bddf05cfac99c3);
									AppMain.cdf464e19f0e36e472601336aa05e5d18.c5b8a8ab26ef0e29e7173cb4e2915e2d6(c591b3807e3508f06381b8edb380d1130.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c36f14603976d7f8bddf05cfac99c3.ccc1b6474af18a76c36a3ba11d663bf35), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98968) != 0);
									cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(38874)));
									this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9 = AppMain.cdf464e19f0e36e472601336aa05e5d18.c8212c323cbad2bba6c6c5da4ae324873(c36f14603976d7f8bddf05cfac99c3.ccc1b6474af18a76c36a3ba11d663bf35, c36f14603976d7f8bddf05cfac99c3.c46f2a4ad19b1705266ba99a93e7f5e6b, this.c8a12ec6aaaa9d79fcdc7c5dabdc3e283, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98972) != 0, this.cf7f9dd41b0e6b39e2c5be23b31594c5c, this.c0e7f2605098a287d665d29e90ff19981, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206045), this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96, AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c4227efd8356857d0af56cc4e83cdaee7());
									this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9.add_c03506d53ef036c610d91b5dc70db4303(new CoreInternal.c30073906c1647fb672cf43ea83304097(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.c5a90aef26704b6b306717a50c7b22b73));
								}
								else
								{
									List<c3588145757b357d2914eb656b313ecae> list3 = AppMain.c184a42a74d25a49281e3c84092602419.c39c4123f5a98f990da5c03fbbe3eb316();
									if (cb60f82a4d3832ddd94abec4b7cb495ce.c30767ddca1f9c207888833aea5b5fc61(list3) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98976))
									{
										while (true)
										{
											switch (7)
											{
											case 0:
												continue;
											}
											break;
										}
										bool flag3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98980) != 0;
										try
										{
											object ce7afbb9027bf2feb71f836f6a31f2d;
											cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d = c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98984)).ce7afbb9027bf2feb71f836f6a31f2d37, ref flag3);
											c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98988)).ce0db3e4869f83e785fd6b3f882c2ad50 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98992);
											c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(98996)).ca8123d02877c101ca9d6878779e5867f = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99000);
											ca081a66cee3bf2dcb0f3ee208852b645.c30767ddca1f9c207888833aea5b5fc61(c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99004)).cc2cf678c05af30b3d1766fa545d867c1, new ca8854b46c089fdef00095522a8028d6c(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c4227efd8356857d0af56cc4e83cdaee7(), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(204958), text15), array12, array11).c442e09b1de2262d3a3a28826b3ea696f());
											long num10 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
											while (num10 + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99020) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
											{
												c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99008));
												if (c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99012)).ce0db3e4869f83e785fd6b3f882c2ad50 != 0)
												{
													while (true)
													{
														switch (5)
														{
														case 0:
															continue;
														}
														break;
													}
													if (c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99016)).ca8123d02877c101ca9d6878779e5867f != 0)
													{
														IL_31E9:
														cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(38874)));
														this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9 = AppMain.cdf464e19f0e36e472601336aa05e5d18.c8212c323cbad2bba6c6c5da4ae324873(c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99024)).ca8123d02877c101ca9d6878779e5867f, c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99028)).ce0db3e4869f83e785fd6b3f882c2ad50, this.c8a12ec6aaaa9d79fcdc7c5dabdc3e283, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99032) != 0, this.cf7f9dd41b0e6b39e2c5be23b31594c5c, this.c0e7f2605098a287d665d29e90ff19981, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206045), this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96, AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c4227efd8356857d0af56cc4e83cdaee7());
														this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ca124a9f406cda69b904f2eb04d553ab9.add_c03506d53ef036c610d91b5dc70db4303(new CoreInternal.c30073906c1647fb672cf43ea83304097(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.c5a90aef26704b6b306717a50c7b22b73));
														goto IL_32D4;
													}
													while (true)
													{
														switch (6)
														{
														case 0:
															continue;
														}
														break;
													}
												}
											}
											while (true)
											{
												switch (5)
												{
												case 0:
													continue;
												}
												goto IL_31E9;
											}
										}
										finally
										{
											if (flag3)
											{
												while (true)
												{
													switch (1)
													{
													case 0:
														continue;
													}
													break;
												}
												object ce7afbb9027bf2feb71f836f6a31f2d;
												c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d);
											}
										}
									}
								}
								IL_32D4:;
							}
							this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(98386))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
							return;
						}
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(99748))), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
					return;
				}
			}

			// Token: 0x04001528 RID: 5416
			public cbf4111912aed594f2b4372828dd95aa3.c42fc2c3d20f7176b8dfba4608d506523 c768dcb1024d7c851c6be8448d9e02a5a;

			// Token: 0x04001529 RID: 5417
			public byte cf7f9dd41b0e6b39e2c5be23b31594c5c;

			// Token: 0x0400152A RID: 5418
			public byte c0e7f2605098a287d665d29e90ff19981;

			// Token: 0x0400152B RID: 5419
			public c9dc78792fcb683123688a66f4d248388 c8a12ec6aaaa9d79fcdc7c5dabdc3e283;

			// Token: 0x0400152C RID: 5420
			public string c89ca75054b1fbd963984dc44a4afd9c0;

			// Token: 0x02000594 RID: 1428
			private sealed class c1f75a77c25eb1ab41e6dff3f8d5732b5
			{
				// Token: 0x06001FA9 RID: 8105 RVA: 0x00148590 File Offset: 0x00146790
				public void cc81f58610ff6f780b96aa509b5f10ecb()
				{
					cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397.cd2e0a506e2cb66de365505ecbcb55ca0, "");
					cce9c6970ae3314a1c0a269eb03d3cfa1.c30767ddca1f9c207888833aea5b5fc61(this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397.cc728d3ce210ddf00a0c34bf5422a78c9, c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206070), this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206324)));
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397.c69fefeee040ccd0fb0491e1b339c1566(this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5);
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397.cbd31021d0be605c2efd37e991a4c8e0d();
					c3aea968f2d6ebafa3e82a7682de441f0.c30767ddca1f9c207888833aea5b5fc61(this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397);
					this.c75caea119109a1c6a383d45205ff13b4 = c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397.cd2e0a506e2cb66de365505ecbcb55ca0);
				}

				// Token: 0x0400152D RID: 5421
				public cbf4111912aed594f2b4372828dd95aa3.c9274186166aa974ae7c5bdefc671df92 c8475b979f583351cce825a43e895c342;

				// Token: 0x0400152E RID: 5422
				public cbf4111912aed594f2b4372828dd95aa3.c42fc2c3d20f7176b8dfba4608d506523 c768dcb1024d7c851c6be8448d9e02a5a;

				// Token: 0x0400152F RID: 5423
				public string c75caea119109a1c6a383d45205ff13b4;
			}

			// Token: 0x02000595 RID: 1429
			private sealed class c2586ec3ff99991d1afc054c7dc5437d3
			{
				// Token: 0x06001FAB RID: 8107 RVA: 0x00148690 File Offset: 0x00146890
				public void c3472f1ab295e2ddf76eda6879eccc099()
				{
					cd0a162bf4ccd330be67d788f4636178b.c30767ddca1f9c207888833aea5b5fc61(this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397.cd2e0a506e2cb66de365505ecbcb55ca0, "");
					cce9c6970ae3314a1c0a269eb03d3cfa1.c30767ddca1f9c207888833aea5b5fc61(this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397.cc728d3ce210ddf00a0c34bf5422a78c9, c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206070), this.c768dcb1024d7c851c6be8448d9e02a5a.cdc42dd0acc0401cea523023c11463c96.ce1ed6a6cb7304463ffd824d14b62f430.cb5466a044809fda944eb67b4c5d2c8f6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206324)));
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397.c69fefeee040ccd0fb0491e1b339c1566(this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5);
					this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397.cbd31021d0be605c2efd37e991a4c8e0d();
					c3aea968f2d6ebafa3e82a7682de441f0.c30767ddca1f9c207888833aea5b5fc61(this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397);
					this.c75caea119109a1c6a383d45205ff13b4 = c7cd8ff5291275fd5f74d564bb023cb8f.c30767ddca1f9c207888833aea5b5fc61(this.c768dcb1024d7c851c6be8448d9e02a5a.cb6ea3d298d68be569f5410cc290458d5.cda9121000da1204e1c6c6b5074e82397.cd2e0a506e2cb66de365505ecbcb55ca0);
				}

				// Token: 0x04001530 RID: 5424
				public cbf4111912aed594f2b4372828dd95aa3.c9274186166aa974ae7c5bdefc671df92 c8475b979f583351cce825a43e895c342;

				// Token: 0x04001531 RID: 5425
				public cbf4111912aed594f2b4372828dd95aa3.c42fc2c3d20f7176b8dfba4608d506523 c768dcb1024d7c851c6be8448d9e02a5a;

				// Token: 0x04001532 RID: 5426
				public string c75caea119109a1c6a383d45205ff13b4;
			}
		}

		// Token: 0x02000596 RID: 1430
		[CompilerGenerated]
		private sealed class c7a3df66530e3730db75913af5d98b71c
		{
			// Token: 0x06001FAD RID: 8109 RVA: 0x00148790 File Offset: 0x00146990
			public bool c0265fb29c22d9b4ec3ae9deb68ead851(ServerTreeViewInfo serverTreeViewInfo)
			{
				return c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbe1f0628b2f175e7b758facaccaa1116.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo), c2b2703f8d5dda9c922e7b8a4df1cb1df.cea69e7c4d1a729bd5783221de1566e79(c63eec5f5fa5b955ae3efb28da0d563e1.c30767ddca1f9c207888833aea5b5fc61(cccc4e141f0000245fdf2ebb12de1a445.c30767ddca1f9c207888833aea5b5fc61(this.cbbeb35f186b790f432ceeaae457dfa3e), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99036))));
			}

			// Token: 0x06001FAE RID: 8110 RVA: 0x001487D4 File Offset: 0x001469D4
			public bool c98e181ea738108b77513188ef263e949(ServerTreeViewInfo serverTreeViewInfo)
			{
				return c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbe1f0628b2f175e7b758facaccaa1116.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo), c2b2703f8d5dda9c922e7b8a4df1cb1df.cea69e7c4d1a729bd5783221de1566e79(c63eec5f5fa5b955ae3efb28da0d563e1.c30767ddca1f9c207888833aea5b5fc61(cccc4e141f0000245fdf2ebb12de1a445.c30767ddca1f9c207888833aea5b5fc61(this.cbbeb35f186b790f432ceeaae457dfa3e), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99040))));
			}

			// Token: 0x06001FAF RID: 8111 RVA: 0x00148818 File Offset: 0x00146A18
			public bool c822f3916ffa256f94e2eaedb3e7c5fa8(ServerTreeViewInfo serverTreeViewInfo)
			{
				return c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbe1f0628b2f175e7b758facaccaa1116.c30767ddca1f9c207888833aea5b5fc61(serverTreeViewInfo), c2b2703f8d5dda9c922e7b8a4df1cb1df.cea69e7c4d1a729bd5783221de1566e79(c63eec5f5fa5b955ae3efb28da0d563e1.c30767ddca1f9c207888833aea5b5fc61(cccc4e141f0000245fdf2ebb12de1a445.c30767ddca1f9c207888833aea5b5fc61(this.cbbeb35f186b790f432ceeaae457dfa3e), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99044))));
			}

			// Token: 0x04001533 RID: 5427
			public SelectionChangedEventArgs cbbeb35f186b790f432ceeaae457dfa3e;
		}
	}
}
