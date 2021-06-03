﻿using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using NUnit.Framework;

namespace CommunityToolkit.Maui.Markup.UnitTests
{
    [TestFixture]
    public class LabelExtensionsTests : MarkupBaseTestFixture<Label>
    {
        Label Label => Bindable ?? throw new NullReferenceException();

        [Test]
        public void TextStart()
            => TestPropertiesSet(l => l?.TextStart(), (Label.HorizontalTextAlignmentProperty, TextAlignment.End, TextAlignment.Start));

        [Test]
        public void TextCenterHorizontal()
            => TestPropertiesSet(l => l?.TextCenterHorizontal(), (Label.HorizontalTextAlignmentProperty, TextAlignment.Start, TextAlignment.Center));

        [Test]
        public void TextEnd()
            => TestPropertiesSet(l => l?.TextEnd(), (Label.HorizontalTextAlignmentProperty, TextAlignment.Start, TextAlignment.End));

        [Test]
        public void TextTop()
            => TestPropertiesSet(l => l?.TextTop(), (Label.VerticalTextAlignmentProperty, TextAlignment.End, TextAlignment.Start));

        [Test]
        public void TextCenterVertical()
            => TestPropertiesSet(l => l?.TextCenterVertical(), (Label.VerticalTextAlignmentProperty, TextAlignment.Start, TextAlignment.Center));

        [Test]
        public void TextBottom()
            => TestPropertiesSet(l => l?.TextBottom(), (Label.VerticalTextAlignmentProperty, TextAlignment.Start, TextAlignment.End));

        [Test]
        public void TextCenter()
            => TestPropertiesSet(
                    l => l?.TextCenter(),
                    (Label.HorizontalTextAlignmentProperty, TextAlignment.Start, TextAlignment.Center),
                    (Label.VerticalTextAlignmentProperty, TextAlignment.Start, TextAlignment.Center));

        [Test]
        public void FontSize()
            => TestPropertiesSet(l => l?.FontSize(8.0), (Label.FontSizeProperty, 6.0, 8.0));

        [Test]
        public void Bold()
            => TestPropertiesSet(l => l?.Bold(), (Label.FontAttributesProperty, FontAttributes.None, FontAttributes.Bold));

        [Test]
        public void Italic()
            => TestPropertiesSet(l => l?.Italic(), (Label.FontAttributesProperty, FontAttributes.None, FontAttributes.Italic));

        [Test]
        public void FormattedTextSingleSpan()
        {
            Label.FormattedText = null;
            Label.FormattedText(
                new Span { BackgroundColor = Color.FromRgb(0, 0, 1) }
            );

            var spans = Label.FormattedText?.Spans;
            Assert.That(spans?.Count == 1 && spans[0].BackgroundColor == Color.FromRgb(0, 0, 1));
        }

        [Test]
        public void FormattedTextMultipleSpans()
        {
            Label.FormattedText = null;
            Label.FormattedText(
                new Span { BackgroundColor = Color.FromRgb(0, 0, 1) },
                new Span { BackgroundColor = Color.FromRgb(0, 1, 0) }
            );

            var spans = Label.FormattedText?.Spans;
            Assert.That(spans?.Count == 2 && spans[0].BackgroundColor == Color.FromRgb(0, 0, 0) && spans[1].BackgroundColor == Color.FromRgb(0, 1, 0));
        }

        [Test]
        public void SupportDerivedFromLabel()
        {
            Assert.IsInstanceOf<DerivedFromLabel>(
                new DerivedFromLabel()
                .TextStart()
                .TextCenterHorizontal()
                .TextEnd()
                .TextTop()
                .TextCenterVertical()
                .TextBottom()
                .TextCenter()
                .FontSize(8.0)
                .Bold()
                .Italic()
                .FormattedText());
        }

        class DerivedFromLabel : Label { }
    }
}