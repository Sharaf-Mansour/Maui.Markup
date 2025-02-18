﻿using CommunityToolkit.Maui.Markup.UnitTests.Base;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;
using NUnit.Framework;

namespace CommunityToolkit.Maui.Markup.UnitTests;

[TestFixture]
class FlexLayoutExtensionsTests : BaseMarkupTestFixture<BoxView>
{
	[Test]
	public void AlignSelf()
	{
		FlexLayout.SetAlignSelf(Bindable, FlexAlignSelf.End);
		Bindable.AlignSelf(FlexAlignSelf.Start);

		Assert.That(FlexLayout.GetAlignSelf(Bindable), Is.EqualTo(FlexAlignSelf.Start));
	}

	[Test]
	public void Basis()
	{
		FlexLayout.SetBasis(Bindable, FlexBasis.Auto);
		Bindable.Basis(50);

		Assert.That(FlexLayout.GetBasis(Bindable), Is.EqualTo(new FlexBasis(50)));
	}

	[Test]
	public void BasisWithPrimitives()
	{
		FlexLayout.SetBasis(Bindable, FlexBasis.Auto);
		Bindable.Basis(0.5f, true);

		Assert.That(FlexLayout.GetBasis(Bindable), Is.EqualTo(new FlexBasis(0.5f, true)));

		Bindable.Basis(55, false);
		Assert.That(FlexLayout.GetBasis(Bindable), Is.EqualTo(new FlexBasis(55, false)));
	}

	[Test]
	public void Grow()
	{
		FlexLayout.SetGrow(Bindable, 0f);
		Bindable.Grow(1f);

		Assert.That(FlexLayout.GetGrow(Bindable), Is.EqualTo(1f));
	}

	[Test]
	public void Order()
	{
		FlexLayout.SetOrder(Bindable, 0);
		Bindable.Order(1);

		Assert.That(FlexLayout.GetOrder(Bindable), Is.EqualTo(1));
	}

	[Test]
	public void Shrink()
	{
		FlexLayout.SetShrink(Bindable, 1f);
		Bindable.Shrink(0f);

		Assert.That(FlexLayout.GetShrink(Bindable), Is.EqualTo(0f));
	}
}