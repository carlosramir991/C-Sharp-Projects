# Generated by Django 2.2.5 on 2020-10-28 04:15

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='Book',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('bk_title', models.CharField(blank=True, default='', max_length=100)),
                ('bk_author', models.CharField(blank=True, default='', max_length=60)),
            ],
        ),
    ]
