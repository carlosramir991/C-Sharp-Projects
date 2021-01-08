# Generated by Django 2.2.5 on 2020-10-22 15:34

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('RickAndMorty', '0003_auto_20201021_1542'),
    ]

    operations = [
        migrations.AlterField(
            model_name='characters',
            name='alignment',
            field=models.CharField(choices=[('good', 'good'), ('evil', 'evil'), ('neutral', 'neutral')], default='', max_length=10, verbose_name='Character Alignment'),
            preserve_default=False,
        ),
        migrations.AlterField(
            model_name='characters',
            name='catchPhrase',
            field=models.CharField(default='', max_length=60, verbose_name='Character Catch Phrase'),
        ),
        migrations.AlterField(
            model_name='characters',
            name='description',
            field=models.TextField(default='', max_length=300, verbose_name='Character Description'),
        ),
        migrations.AlterField(
            model_name='characters',
            name='name',
            field=models.CharField(default='', max_length=60, verbose_name='Character Name'),
        ),
    ]
